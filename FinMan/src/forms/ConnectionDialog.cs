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
    public delegate bool ConnectionListener(string connStr);
    public delegate int SigninListener(string username, string password, int action, bool admin);

    public partial class ConnectionDialog : Form
    {
        public ConnectionListener connListener { get; set; }
        public SigninListener signinListener { get; set; }

        private ForgotDialog forgotDialog;

        public ConnectionDialog()
        {
            InitializeComponent();

            forgotDialog = new ForgotDialog();

            forgotDialog.updateListener = (string username, string password) =>
            {
                return signinListener(username, password, 2, false) != -1;
            };
        }

        private void serverConnect_btn_Click(object sender, EventArgs e)
        {
            string connStr = this.connStr_textbox.Text;

            // connect to server
            if (!connListener(connStr))
            {
                this.serverStat_status.Text = "failed to connect";
                return;
            }

            this.connStr_textbox.Enabled = false;
            this.serverConnect_btn.Enabled = false;
            this.serverDisconnect_btn.Enabled = true;
            this.serverStat_status.Text = "connected";

            this.signup_chkbox.Enabled = true;
            this.username_textbox.Enabled = true;
            this.password_textbox.Enabled = true;

            // layout bottom pane
            signup_chkbox_CheckedChanged(null, null);
        }

        private void serverDisconnect_btn_Click(object sender, EventArgs e)
        {
            // signout
            if(this.signout_btn.Enabled)
                this.signout_btn.PerformClick();

            // disconnect from server
            if (this.signout_btn.Enabled || !connListener(null))
            {
                this.serverStat_status.Text = "failed to disconnect";
                return;
            }

            this.connStr_textbox.Enabled = true;
            this.serverConnect_btn.Enabled = true;
            this.serverDisconnect_btn.Enabled = false;
            this.serverStat_status.Text = "disconnected";

            this.signout_btn.Enabled = false;
            this.signin_btn.Enabled = false;
            this.signup_btn.Enabled = false;
            this.signup_chkbox.Enabled = false;
            this.admin_chkbox.Enabled = false;
            this.forgotPwd_link.Enabled = false;
            this.username_textbox.Enabled = false;
            this.password_textbox.Enabled = false;
        }

        private void signup_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.signup_chkbox.Checked)
            {
                this.signup_btn.Visible = true;
                this.signup_btn.Enabled = true;
                this.signin_btn.Visible = false;
                this.signin_btn.Enabled = false;
                this.signout_btn.Visible = false;
                this.admin_chkbox.Enabled = true;
                this.admin_chkbox.Checked = false;
                this.forgotPwd_link.Visible = false;
                this.forgotPwd_link.Enabled = false;
            }
            else
            {
                this.signup_btn.Visible = false;
                this.signup_btn.Enabled = false;
                this.signin_btn.Visible = true;
                this.signin_btn.Enabled = true;
                this.signout_btn.Visible = true;
                this.signout_btn.Enabled = false;
                this.admin_chkbox.Enabled = false;
                this.admin_chkbox.Checked = false;
                this.forgotPwd_link.Visible = true;
                this.forgotPwd_link.Enabled = true;
            }
        }

        private void forgotPwd_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotDialog.reset();
            forgotDialog.ShowDialog();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            // signup user
            string username = this.username_textbox.Text;
            string password = this.password_textbox.Text;
            bool admin = this.admin_chkbox.Checked;
            if (username == "" || password == "" || signinListener(username, password, 1, admin) == -1)
            {
                this.loginStat_status.Text = "failed to add user";
                return;
            }

            // signin user
            this.signup_chkbox.Checked = false;
            signup_chkbox_CheckedChanged(null, null);
            this.signin_btn.PerformClick();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            // signin user
            string username = this.username_textbox.Text;
            string password = this.password_textbox.Text;
            int res = -1;
            if(username != "" && password != "")
                res = signinListener(username, password, 0, false);
            if (res == -1)
            {
                this.loginStat_status.Text = "failed to sign in";
                return;
            }

            bool admin = (res == 1) ? true : false;

            this.signup_chkbox.Enabled = false;
            this.username_textbox.Enabled = false;
            this.password_textbox.Enabled = false;
            this.admin_chkbox.Checked = admin;
            this.forgotPwd_link.Enabled = false;

            this.signin_btn.Enabled = false;
            this.signout_btn.Enabled = true;
            this.delAcc_btn.Visible = true;
            this.loginStat_status.Text = "signed in";
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            // signout user
            if (signinListener(null, null, -2, false) == -1)
            {
                this.loginStat_status.Text = "failed to sign out";
                return;
            }

            this.signup_chkbox.Enabled = true;
            this.username_textbox.Enabled = true;
            this.password_textbox.Enabled = true;
            this.admin_chkbox.Checked = false;
            this.forgotPwd_link.Enabled = true;

            this.signin_btn.Enabled = true;
            this.signout_btn.Enabled = false;
            this.delAcc_btn.Visible = false;
            this.loginStat_status.Text = "signed out";
        }

        private void delAcc_btn_Click(object sender, EventArgs e)
        {
            // signout user
            this.signout_btn.PerformClick();

            if (signinListener(null, null, -1, false) == -1)
            {
                this.loginStat_status.Text = "failed to delete user";
                return;
            }
        }
    }
}
