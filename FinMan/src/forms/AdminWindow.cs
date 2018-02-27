using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinMan.forms.AccountType;
using FinMan.forms.ExpenseType;
using FinMan.forms.IncomeType;

namespace FinMan.forms
{
    public delegate bool AdminModifyListener(int selection, string type, int action, int id);

    public partial class AdminWindow : Form
    {
        public TableUpdateListener update { get; set; }
        public AdminModifyListener adminModifyListener { get; set; }

        private AddAccountTypeDialog addAccDialog;
        private EditAccountTypeDialog editAccDialog;
        private AddExpenseTypeDialog addExpDialog;
        private EditExpenseTypeDialog editExpDialog;
        private AddIncomeTypeDialog addIncDialog;
        private EditIncomeTypeDialog editIncDialog;

        public AdminWindow()
        {
            InitializeComponent();

            this.addAccDialog = new AddAccountTypeDialog();
            this.editAccDialog = new EditAccountTypeDialog();
            this.addExpDialog = new AddExpenseTypeDialog();
            this.editExpDialog = new EditExpenseTypeDialog();
            this.addIncDialog = new AddIncomeTypeDialog();
            this.editIncDialog = new EditIncomeTypeDialog();

            addAccDialog.addAccountType = (int selection, string type, int action, int id) =>
            {
                return adminModifyListener(selection, type, action, id);
            };

            editAccDialog.updateAccountType = (int selection, string type, int action, int id) =>
            {
                return adminModifyListener(selection, type, action, id);
            };

            addExpDialog.addExpenseType = (int selection, string type, int action, int id) =>
            {
                return adminModifyListener(selection, type, action, id);
            };

            editExpDialog.updateExpenseType = (int selection, string type, int action, int id) =>
            {
                return adminModifyListener(selection, type, action, id);
            };

            addIncDialog.addIncomeType = (int selection, string type, int action, int id) =>
            {
                return adminModifyListener(selection, type, action, id);
            };

            editIncDialog.updateIncType = (int selection, string type, int action, int id) =>
            {
                return adminModifyListener(selection, type, action, id);
            };
        }

        public void updateAccTable(DataSet source)
        {
            if(source.Tables[0] != null)
            {
                this.acc_gridview.DataSource = source.Tables[0];
                this.accAdd_btn.Enabled = true;
            }
            else
            {
                this.acc_gridview.DataSource = null;

                this.accAdd_btn.Enabled = false;
                this.accEdit_btn.Enabled = false;
                this.accDel_btn.Enabled = false;
            }
        }

        public void updateExpTable(DataSet source)
        {
            if (source.Tables[0] != null)
            {
                this.exp_gridview.DataSource = source.Tables[0];
                this.expAdd_btn.Enabled = true;
            }
            else
            {
                this.exp_gridview.DataSource = null;

                this.expAdd_btn.Enabled = false;
                this.expEdit_btn.Enabled = false;
                this.expDel_btn.Enabled = false;
            }
        }

        public void updateIncTable(DataSet source)
        {
            if (source.Tables[0] != null)
            {
                this.inc_gridview.DataSource = source.Tables[0];
                this.incAdd_btn.Enabled = true;
            }
            else
            {
                this.inc_gridview.DataSource = null;

                this.incAdd_btn.Enabled = false;
                this.incEdit_btn.Enabled = false;
                this.incDel_btn.Enabled = false;
            }
        }

        private void acc_gridview_RowSelection(Object sender, EventArgs e)
        {
            if (this.acc_gridview.SelectedRows.Count > 0)
            {
                this.accEdit_btn.Enabled = true;
                this.accDel_btn.Enabled = true;
            }
            else
            {
                this.accEdit_btn.Enabled = false;
                this.accDel_btn.Enabled = false;
            }
        }

        private void exp_gridview_RowSelection(Object sender, EventArgs e)
        {
            if (this.exp_gridview.SelectedRows.Count > 0)
            {
                this.expEdit_btn.Enabled = true;
                this.expDel_btn.Enabled = true;
            }
            else
            {
                this.expEdit_btn.Enabled = false;
                this.expDel_btn.Enabled = false;
            }
        }

        private void inc_gridview_RowSelection(Object sender, EventArgs e)
        {
            if (this.inc_gridview.SelectedRows.Count > 0)
            {
                this.incEdit_btn.Enabled = true;
                this.incDel_btn.Enabled = true;
            }
            else
            {
                this.incEdit_btn.Enabled = false;
                this.incDel_btn.Enabled = false;
            }
        }

        private void refrsh_btn_Click(object sender, EventArgs e)
        {
            update();
        }

        private void accAdd_btn_Click(object sender, EventArgs e)
        {
            addAccDialog.reset();
            addAccDialog.ShowDialog();

            this.refrsh_btn.PerformClick();
        }

        private void accEdit_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.acc_gridview.SelectedRows[0];
            string type = (string)row.Cells["acc_type"].Value;
            int id = (int)row.Cells["acc_type_id"].Value;

            editAccDialog.reset(type, id);
            editAccDialog.ShowDialog();

            this.refrsh_btn.PerformClick();
        }

        private void accDel_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.acc_gridview.SelectedRows[0];
            int id = (int)row.Cells["acc_type_id"].Value;

            adminModifyListener(0, null, -1, id);

            this.refrsh_btn.PerformClick();
        }

        private void expAdd_btn_Click(object sender, EventArgs e)
        {
            addExpDialog.reset();
            addExpDialog.ShowDialog();

            this.refrsh_btn.PerformClick();
        }

        private void expEdit_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.exp_gridview.SelectedRows[0];
            string type = (string)row.Cells["exp_type"].Value;
            int id = (int)row.Cells["exp_id"].Value;

            editExpDialog.reset(type, id);
            editExpDialog.ShowDialog();

            this.refrsh_btn.PerformClick();
        }

        private void expDel_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.exp_gridview.SelectedRows[0];
            int id = (int)row.Cells["exp_id"].Value;

            adminModifyListener(-1, null, -1, id);

            this.refrsh_btn.PerformClick();
        }

        private void incAdd_btn_Click(object sender, EventArgs e)
        {
            addIncDialog.reset();
            addIncDialog.ShowDialog();

            this.refrsh_btn.PerformClick();
        }

        private void incEdit_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.inc_gridview.SelectedRows[0];
            string type = (string)row.Cells["inc_type"].Value;
            int id = (int)row.Cells["inc_id"].Value;

            editIncDialog.reset(type, id);
            editIncDialog.ShowDialog();

            this.refrsh_btn.PerformClick();
        }

        private void incDel_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.inc_gridview.SelectedRows[0];
            int id = (int)row.Cells["inc_id"].Value;

            adminModifyListener(1, null, -1, id);

            this.refrsh_btn.PerformClick();
        }
    }
}
