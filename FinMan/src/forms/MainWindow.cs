using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using FinMan.forms.Transaction;

namespace FinMan.forms
{
    public delegate void SettingsListener();
    public delegate void TableUpdateListener();

    public delegate bool ModifyTransactionListener(int acc_id, int type, int type_id, int amount, DateTime time, string desc, int action, int id);

    public delegate DataSet SqlDataSetQuery(string comm, bool userOnly);
    public delegate SqlDataReader SqlDataReaderQuery(string comm, bool userOnly);

    public partial class MainWindow : Form
    {
        public SettingsListener showSettings { get; set; }
        public TableUpdateListener update { get; set; }
        public SqlDataSetQuery getDataSet { get; set; }
        public ModifyAccountListener modifyListener { get; set; }
        public AdminModifyListener adminModifyListener { get; set; }
        public ModifyTransactionListener modifyTransactionListener { get; set; }

        private string viewComm;

        private AccountsDialog accountsDialog;
        private AdminWindow adminWindow;
        private AddTransactionDialog addTranDialog;
        private EditTransactionDialog editTranDialog;
        private EditViewDialog editViewDialog;

        public MainWindow()
        {
            InitializeComponent();

            accountsDialog = new AccountsDialog();
            adminWindow = new AdminWindow();
            addTranDialog = new AddTransactionDialog();
            editTranDialog = new EditTransactionDialog();
            editViewDialog = new EditViewDialog();

            accountsDialog.modifyListener = (string name, int type_id, int balance, string desc, int action, int acc_id) =>
            {
                return modifyListener(name, type_id, balance, desc, action, acc_id);
            };

            accountsDialog.update = () =>
            {
                DataSet data = getDataSet("SELECT Acc.user_id, Acc.acc_id, Acc.acc_type_id, Acc.name AS [Name], AccTyp.acc_type AS [Type], Acc.description AS [Description] FROM dbo.Accounts AS Acc INNER JOIN dbo.AccountTypes AS AccTyp ON Acc.acc_type_id = AccTyp.acc_type_id", true);
                accountsDialog.updateTable(data);
            };

            accountsDialog.getDataSet = (string comm, bool userOnly) => { return getDataSet(comm, userOnly); };

            adminWindow.adminModifyListener = (int selection, string type, int action, int id) =>
            {
                return adminModifyListener(selection, type, action, id);
            };

            adminWindow.update = () =>
            {
                DataSet data = getDataSet("SELECT * FROM dbo.AccountTypes WHERE acc_type IS NOT NULL", false);
                adminWindow.updateAccTable(data);

                data = getDataSet("SELECT * FROM dbo.ExpenseTypes WHERE exp_type IS NOT NULL", false);
                adminWindow.updateExpTable(data);

                data = getDataSet("SELECT * FROM dbo.IncomeTypes WHERE inc_type IS NOT NULL", false);
                adminWindow.updateIncTable(data);
            };

            addTranDialog.getDataSet = (string comm, bool userOnly) => { return getDataSet(comm, userOnly); };

            addTranDialog.addTransaction = (int acc_id, int type, int type_id, int amount, DateTime time, string desc, int action, int id) =>
            {
                return modifyTransactionListener(acc_id, type, type_id, amount, time, desc, action, id);
            };

            editTranDialog.getDataSet = (string comm, bool userOnly) => { return getDataSet(comm, userOnly); };

            editTranDialog.updateTransaction = (int acc_id, int type, int type_id, int amount, DateTime time, string desc, int action, int id) =>
            {
                return modifyTransactionListener(acc_id, type, type_id, amount, time, desc, action, id);
            };

            editViewDialog.getDataSet = (string comm, bool userOnly) => { return getDataSet(comm, userOnly); };

            editViewDialog.editView = (string comm) =>
            {
                viewComm = comm;
            };
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSettings();
        }

        public void updateTable()
        { 
            DataSet data = getDataSet(viewComm, true);

            this.tran_gridview.DataSource = data.Tables[0];
            this.addTran_btn.Enabled = true;
        }

        public void updateAccountsTable(DataSet source)
        {
            if (source != null)
            {
                this.acc_gridview.DataSource = source.Tables[0];

                this.editAcc_btn.Enabled = true;
            }
            else
            {
                this.acc_gridview.DataSource = null;

                this.editAcc_btn.Enabled = false;
            }
        }

        public void updateTotalBalance(int balance)
        {
            this.balance_balance.Text = balance.ToString();
        }

        private void editAcc_btn_Click(object sender, EventArgs e)
        {
            accountsDialog.update();
            accountsDialog.ShowDialog();

            this.refresh_btn.PerformClick();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            update();

            this.tran_gridview.Columns[0].Visible = false;
            this.tran_gridview.Columns[1].Visible = false;
            this.tran_gridview.Columns[2].Visible = false;
            this.tran_gridview.Columns[3].Visible = false;
            this.tran_gridview.Columns[4].Visible = false;

            this.acc_gridview.Columns[0].Visible = false;
        }

        public void connect(bool connect, bool admin)
        {
            if (connect)
            {
                viewComm = "SELECT T.tran_id, T.user_id, T.acc_id, T.exp_id, T.inc_id, Acc.name AS [Account], Exp.exp_type AS [Expense Type], Inc.inc_type AS [Income Type], T.amount AS [Amount], T.date AS [Time], T.description AS [Description] FROM dbo.Transactions AS T INNER JOIN dbo.Accounts AS Acc ON T.acc_id = Acc.acc_id LEFT JOIN dbo.IncomeTypes AS Inc ON Inc.inc_id = T.inc_id LEFT JOIN dbo.ExpenseTypes AS Exp ON Exp.exp_id = T.exp_id WHERE T.acc_id IS NOT NULL";
                updateTable();

                this.refresh_btn.Enabled = true;
                this.view_btn.Enabled = true;
                editViewDialog.reset();
                if (admin)
                {
                    this.admin_btn.Visible = true;
                }

                this.refresh_btn.PerformClick();
            }
            else
            {
                this.tran_gridview.DataSource = null;
                this.addTran_btn.Enabled = false;
                this.editTran_btn.Enabled = false;
                this.delTran_btn.Enabled = false;

                this.balance_balance.Text = "";
                this.refresh_btn.Enabled = false;
                this.view_btn.Enabled = false;
                this.admin_btn.Visible = false;
                this.adminWindow.Hide();
            }
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            adminWindow.update();
            adminWindow.ShowDialog();

            this.refresh_btn.PerformClick();
        }

        private void tran_gridview_RowSelection(Object sender, EventArgs e)
        {
            if(tran_gridview.SelectedRows.Count > 0)
            {
                this.editTran_btn.Enabled = true;
                this.delTran_btn.Enabled = true;
            }
            else
            {
                this.editTran_btn.Enabled = false;
                this.delTran_btn.Enabled = false;
            }
        }

        private void addTran_btn_Click(object sender, EventArgs e)
        {
            addTranDialog.reset();
            addTranDialog.ShowDialog();

            this.refresh_btn.PerformClick();
        }

        private void editTran_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.tran_gridview.SelectedRows[0];
            int acc_id = (int)row.Cells["acc_id"].Value;
            int amount = (int)row.Cells["Amount"].Value;
            int type = 0;
            int type_id = 0;
            if(amount > 0)
            {
                type = 1;
                type_id = (int)row.Cells["inc_id"].Value;
            }
            else
            {
                type = -1;
                type_id = (int)row.Cells["exp_id"].Value;
            }
            string desc = (string)row.Cells["Description"].Value;
            DateTime time = (DateTime)row.Cells["Time"].Value;
            int id = (int)row.Cells["tran_id"].Value;

            editTranDialog.reset(acc_id, type, type_id, amount, time, desc, id);
            editTranDialog.ShowDialog();

            this.refresh_btn.PerformClick();
        }

        private void delTran_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.tran_gridview.SelectedRows[0];
            int id = (int)row.Cells["tran_id"].Value;

            modifyTransactionListener(0, 0, 0, 0, DateTime.Now, null, -1, id);

            this.refresh_btn.PerformClick();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            editViewDialog.update();
            editViewDialog.ShowDialog();

            this.refresh_btn.PerformClick();
        }
    }
}
