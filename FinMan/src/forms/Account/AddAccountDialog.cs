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
    public partial class AddAccountDialog : Form
    {
        public ModifyAccountListener addAccount { get; set; }
        public SqlDataSetQuery getDataSet { get; set; }

        public AddAccountDialog()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            string name = this.name_textbox.Text;
            int type_id = (this.type_combo.SelectedValue != null) ? (int)this.type_combo.SelectedValue : -1;
            int balance;
            string desc = this.desc_textbox.Text;
            if(name == "")
            {
                this.stat_status.Text = "enter a valid name";
                return;
            }
            else if (type_id == -1)
            {
                this.stat_status.Text = "select an account type";
                return;
            }
            else if(!int.TryParse(this.balance_textbox.Text, out balance))
            {
                this.stat_status.Text = "invalid balance";
                return;
            }

            if(addAccount(name, type_id, balance, desc, 1, 0))
            {
                this.Hide();
            }
            else
            {
                this.stat_status.Text = "failed to add account";
            }
        }

        public void reset()
        {
            this.name_textbox.Text = "";
            this.balance_textbox.Text = "";
            this.desc_textbox.Text = "";
            this.stat_status.Text = "enter account details";

            DataSet data = getDataSet("SELECT * FROM dbo.AccountTypes WHERE acc_type IS NOT NULL", false);
            this.type_combo.DataSource = data.Tables[0];
            this.type_combo.DisplayMember = "acc_type";
            this.type_combo.ValueMember = "acc_type_id";
        }
    }
}
