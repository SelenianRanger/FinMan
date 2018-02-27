using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMan.forms
{
    public delegate void ModifyViewListener(string comm);

    public partial class EditViewDialog : Form
    {
        public ModifyViewListener editView { get; set; }
        public SqlDataSetQuery getDataSet { get; set; }

        public EditViewDialog()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void date_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (date_chkbox.Checked)
            {
                this.from_datepicker.Enabled = true;
                this.to_datepicker.Enabled = true;
            }
            else
            {
                this.from_datepicker.Enabled = false;
                this.to_datepicker.Enabled = false;
            }
        }

        public void reset()
        {
            this.date_chkbox.Checked = false;
            this.from_datepicker.Value = DateTime.Now;
            this.to_datepicker.Value = DateTime.Now;

            update();

            for (int i = 0; i < this.inc_chklistbox.Items.Count; i++)
            {
                this.inc_chklistbox.SetItemChecked(i, true);
            }
            for (int i = 0; i < this.exp_chklistbox.Items.Count; i++)
            {
                this.exp_chklistbox.SetItemChecked(i, true);
            }
        }

        public void update()
        {
            DataSet data = getDataSet("SELECT * FROM dbo.IncomeTypes WHERE inc_type IS NOT NULL", false);
            ((ListBox)this.inc_chklistbox).DataSource = data.Tables[0];
            ((ListBox)this.inc_chklistbox).DisplayMember = "inc_type";
            ((ListBox)this.inc_chklistbox).ValueMember = "inc_id";

            data = getDataSet("SELECT * FROM dbo.ExpenseTypes WHERE exp_type IS NOT NULL", false);
            ((ListBox)this.exp_chklistbox).DataSource = data.Tables[0];
            ((ListBox)this.exp_chklistbox).DisplayMember = "exp_type";
            ((ListBox)this.exp_chklistbox).ValueMember = "exp_id";

            this.stat_status.Text = "edit view filter";
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            if(this.inc_chklistbox.CheckedItems.Count == 0 && this.exp_chklistbox.CheckedItems.Count == 0)
            {
                this.stat_status.Text = "select at at least one category";
                return;
            }
            if(this.date_chkbox.Checked && this.to_datepicker.Value < this.from_datepicker.Value)
            {
                this.stat_status.Text = "invalid date filter";
                return;
            }
            string comm = "SELECT * FROM dbo.Transactions WHERE (";
            foreach(var item in this.inc_chklistbox.CheckedItems)
            {
                comm += "inc_id=" + "'" + ((DataRowView)item).Row["inc_id"].ToString() + "' OR ";
            }
            foreach (var item in this.exp_chklistbox.CheckedItems)
            {
                comm += "exp_id=" + "'" + ((DataRowView)item).Row["exp_id"].ToString() + "' OR ";
            }
            comm = comm.Remove(comm.Length - 3);
            comm += ")";
            if (date_chkbox.Checked)
            {
                comm += " AND (date BETWEEN "
                    + "'" + from_datepicker.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND "
                    + "'" + to_datepicker.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            }

            comm += " AND acc_id IS NOT NULL";

            comm = "SELECT T.tran_id, T.user_id, T.acc_id, T.exp_id, T.inc_id, Acc.name AS [Account], Exp.exp_type AS [Expense Type], Inc.inc_type AS [Income Type], T.amount AS [Amount], T.date AS [Time], T.description AS [Description]"
                + " FROM (" + comm + ") As T INNER JOIN dbo.Accounts AS Acc ON T.acc_id = Acc.acc_id LEFT JOIN dbo.IncomeTypes AS Inc ON Inc.inc_id = T.inc_id LEFT JOIN dbo.ExpenseTypes AS Exp ON Exp.exp_id = T.exp_id";

            editView(comm);

            this.Hide();
        }
    }
}
