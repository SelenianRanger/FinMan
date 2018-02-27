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
    public partial class EditAccountDialog : Form
    {
        public ModifyAccountListener updateAccount { get; set; }
        public SqlDataSetQuery getDataSet { get; set; }

        private int acc_id;

        public EditAccountDialog()
        {
            InitializeComponent();
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            string name = this.name_textbox.Text;
            string desc = this.desc_textbox.Text;
            int type_id = (int)this.type_combo.SelectedValue;
            string tmp = this.balance_textbox.Text;
            if(tmp == "")
            {
                tmp = int.MinValue.ToString();
            } 
            int balance;
            if (!int.TryParse(tmp, out balance))
            {
                this.stat_status.Text = "invalid balance";
                return;
            }
            else
            {
                if (updateAccount(name, type_id, balance, desc, 0, acc_id))
                {
                    this.Hide();
                }
                else
                {
                    this.stat_status.Text = "failed to update account details";
                    return;
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void reset(string name, int type_id, string desc, int id)
        {
            acc_id = id;

            this.name_textbox.Text = name;
            this.balance_textbox.Text = "";
            this.desc_textbox.Text = desc;

            this.stat_status.Text = "change account details";

            DataSet data = getDataSet("SELECT * FROM dbo.AccountTypes WHERE acc_type IS NOT NULL", false);
            this.type_combo.DataSource = data.Tables[0];
            this.type_combo.DisplayMember = "acc_type";
            this.type_combo.ValueMember = "acc_type_id";
            if (type_id != -1)
            {
                this.type_combo.SelectedValue = type_id;
            }
        }
    }
}
