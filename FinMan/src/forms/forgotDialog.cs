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
    public delegate bool UpdateListener(string username, string password);

    public partial class ForgotDialog : Form
    {
        public UpdateListener updateListener { get; set; }

        private string username;

        public ForgotDialog()
        {
            InitializeComponent();
        }

        public void reset()
        {
            username = null;

            this.username_textbox.Text = "";
            this.pwd1_textbox.Text = "";
            this.pwd2_textbox.Text = "";

            this.pwd1_label.Visible = false;
            this.pwd1_textbox.Visible = false;
            this.pwd2_label.Visible = false;
            this.pwd2_textbox.Visible = false;

            this.done_btn.Enabled = false;

            this.stat_status.Text = "enter username";
        }

        private void pwd2_textbox_TextChanged(object sender, EventArgs e)
        {
            string pwd1 = this.pwd1_textbox.Text;
            string pwd2 = this.pwd2_textbox.Text;

            if(pwd1 != "" && pwd1 == pwd2)
            {
                this.done_btn.Enabled = true;
            }
            else
            {
                this.done_btn.Enabled = false;
            }
        }

        private void pwd1_textbox_TextChanged(object sender, EventArgs e)
        {
            string pwd1 = this.pwd1_textbox.Text;
            string pwd2 = this.pwd2_textbox.Text;

            if (pwd1 != "" && pwd1 == pwd2)
            {
                this.done_btn.Enabled = true;
            }
            else
            {
                this.done_btn.Enabled = false;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string user = this.username_textbox.Text;
            if(updateListener(user, null))
            {
                username = user;
                this.done_btn.Enabled = false;

                this.pwd1_textbox.Text = "";
                this.pwd2_textbox.Text = "";
                this.pwd1_label.Visible = true;
                this.pwd1_textbox.Visible = true;
                this.pwd2_label.Visible = true;
                this.pwd2_textbox.Visible = true;

                this.stat_status.Text = "enter new password";
            }
            else
            {
                username = null;
                this.done_btn.Enabled = false;

                this.pwd1_textbox.Text = "";
                this.pwd2_textbox.Text = "";
                this.pwd1_label.Visible = false;
                this.pwd1_textbox.Visible = false;
                this.pwd2_label.Visible = false;
                this.pwd2_textbox.Visible = false;

                this.stat_status.Text = "failed to find user";
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            // update user info
            string password = this.pwd1_textbox.Text;
            if(updateListener(username, password))
            {
                this.Hide();
            }
            else
            {
                this.stat_status.Text = "failed to change password";
            }
        }
    }
}
