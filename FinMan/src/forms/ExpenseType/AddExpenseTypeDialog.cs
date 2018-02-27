using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMan.forms.ExpenseType
{
    public partial class AddExpenseTypeDialog : Form
    {
        public AdminModifyListener addExpenseType { get; set; }

        public AddExpenseTypeDialog()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            string type = this.type_textbox.Text;
            if (type == "")
            {
                this.stat_status.Text = "invalid type name";
                return;
            }
            if (!addExpenseType(-1, type, 1, 0))
            {
                this.stat_status.Text = "failed to add expense type";
                return;
            }
            else
            {
                this.Hide();
            }
        }

        public void reset()
        {
            this.type_textbox.Text = "";
            this.stat_status.Text = "enter expense type name";
        }
    }
}
