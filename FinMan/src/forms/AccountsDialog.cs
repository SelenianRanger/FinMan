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
    public delegate bool ModifyAccountListener(string name, int type_id, int balance, string desc, int action, int acc_id);

    public partial class AccountsDialog : Form
    {
        public ModifyAccountListener modifyListener { get; set; }
        public SqlDataSetQuery getDataSet { get; set; }
        public TableUpdateListener update { get; set; }

        private AddAccountDialog addAccDialog;
        private EditAccountDialog editAccDialog;

        public AccountsDialog()
        {
            InitializeComponent();

            addAccDialog = new AddAccountDialog();
            editAccDialog = new EditAccountDialog();

            addAccDialog.addAccount = (string name, int type_id, int balance, string desc, int action, int acc_id) =>
            {
                return modifyListener(name, type_id, balance, desc, action, acc_id);
            };

            addAccDialog.getDataSet = (string comm, bool userOnly) => { return getDataSet(comm, userOnly); };

            editAccDialog.updateAccount = (string name, int type_id, int balance, string desc, int action, int acc_id) =>
            {
                return modifyListener(name, type_id, balance, desc, action, acc_id);
            };

            editAccDialog.getDataSet = (string comm, bool userOnly) => { return getDataSet(comm, userOnly); };
        }

        public void updateTable(DataSet source)
        {
            if (source.Tables[0] != null)
            {
                this.accounts_gridview.DataSource = source.Tables[0];
                this.add_btn.Enabled = true;

                this.accounts_gridview.Columns[0].Visible = false;
                this.accounts_gridview.Columns[1].Visible = false;
                this.accounts_gridview.Columns[2].Visible = false;
            }
            else
            {
                this.accounts_gridview.DataSource = null;
                this.add_btn.Enabled = false;
                this.edit_btn.Enabled = false;
                this.del_btn.Enabled = false;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addAccDialog.reset();
            addAccDialog.ShowDialog();

            this.refresh_btn.PerformClick();
        }

        private void accounts_gridview_RowSelection(Object sender, EventArgs e)
        {
            if (accounts_gridview.SelectedRows.Count > 0)
            {
                this.edit_btn.Enabled = true;
                this.del_btn.Enabled = true;
            }
            else
            {
                this.edit_btn.Enabled = false;
                this.del_btn.Enabled = false;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.accounts_gridview.SelectedRows[0];
            string name = (string)row.Cells["Name"].Value;
            int type_id = (row.Cells["acc_type_id"].Value is DBNull) ? -1 : (int)row.Cells["acc_type_id"].Value;
            string desc = (string)row.Cells["Description"].Value;
            int acc_id = (int)row.Cells["acc_id"].Value;

            editAccDialog.reset(name, type_id, desc, acc_id);
            editAccDialog.ShowDialog();

            this.refresh_btn.PerformClick();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.accounts_gridview.SelectedRows[0];
            int acc_id = (int)row.Cells["acc_id"].Value;
            modifyListener(null, 0, 0, null, -1, acc_id);

            this.refresh_btn.PerformClick();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
