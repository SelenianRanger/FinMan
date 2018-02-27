using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMan.forms.Transaction
{
    public partial class EditTransactionDialog : Form
    {
        public ModifyTransactionListener updateTransaction { get; set; }

        public SqlDataSetQuery getDataSet { get; set; }

        private int id;

        public EditTransactionDialog()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void reset(int acc_id, int type, int type_id, int amount, DateTime time, string desc, int id)
        {
            this.id = id;

            this.amount_textbox.Text = Math.Abs(amount).ToString();
            this.date_picker.Value = time;
            this.desc_textbox.Text = desc;
            this.stat_status.Text = "enter transaction details";

            if(type == 1)
            {
                this.deposit_radiobtn.Checked = true;
                this.pay_radiobtn.Checked = false;
            }
            else
            {
                this.deposit_radiobtn.Checked = false;
                this.pay_radiobtn.Checked = true;
            }

            DataSet data = getDataSet("SELECT * FROM dbo.Accounts", true);
            acc_combo.DataSource = data.Tables[0];
            acc_combo.DisplayMember = "name";
            acc_combo.ValueMember = "acc_id";

            string table = (type == -1) ? "dbo.ExpenseTypes" : "dbo.IncomeTypes";
            string typeName = (type == -1) ? "exp_type" : "inc_type";
            string idName = (type == -1) ? "exp_id" : "inc_id";
            data = getDataSet("SELECT * FROM " + table + " WHERE " + typeName + " IS NOT NULL", false);
            cat_combo.DataSource = data.Tables[0];
            cat_combo.DisplayMember = typeName;
            cat_combo.ValueMember = idName;

            this.acc_combo.SelectedValue = acc_id;
            this.cat_combo.SelectedValue = type_id;
        }

        private void pay_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            string table = (pay_radiobtn.Checked) ? "dbo.ExpenseTypes" : "dbo.IncomeTypes";
            string typeName = (pay_radiobtn.Checked) ? "exp_type" : "inc_type";
            string idName = (pay_radiobtn.Checked) ? "exp_id" : "inc_id";
            DataSet data = getDataSet("SELECT * FROM " + table + " WHERE " + typeName + " IS NOT NULL", false);
            cat_combo.DataSource = data.Tables[0];
            cat_combo.DisplayMember = typeName;
            cat_combo.ValueMember = idName;
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            if (acc_combo.SelectedIndex == -1)
            {
                this.stat_status.Text = "select an account";
                return;
            }
            int acc_id = (int)this.acc_combo.SelectedValue;
            if (cat_combo.SelectedIndex == -1)
            {
                this.stat_status.Text = "select a category";
                return;
            }
            int type_id = (int)this.cat_combo.SelectedValue;
            string am = this.amount_textbox.Text;
            int amount = 0;
            if (!int.TryParse(am, out amount))
            {
                this.stat_status.Text = "invalid amount";
                return;
            }
            DateTime time = this.date_picker.Value;
            string desc = this.desc_textbox.Text;
            int type = (pay_radiobtn.Checked) ? -1 : 1;

            if (!updateTransaction(acc_id, type, type_id, amount, time, desc, 0, id))
            {
                this.stat_status.Text = "failed to update transaction";
                return;
            }
            else
            {
                this.Hide();
            }
        }

    }
}
