namespace FinMan.forms
{
    partial class ConnectionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connStr_label = new System.Windows.Forms.Label();
            this.serverConnect_btn = new System.Windows.Forms.Button();
            this.serverDisconnect_btn = new System.Windows.Forms.Button();
            this.connStr_textbox = new System.Windows.Forms.TextBox();
            this.serverStat_label = new System.Windows.Forms.Label();
            this.serverStat_status = new System.Windows.Forms.Label();
            this.usrCred_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.admin_chkbox = new System.Windows.Forms.CheckBox();
            this.signup_chkbox = new System.Windows.Forms.CheckBox();
            this.signin_btn = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signout_btn = new System.Windows.Forms.Button();
            this.forgotPwd_link = new System.Windows.Forms.LinkLabel();
            this.loginStat_label = new System.Windows.Forms.Label();
            this.loginStat_status = new System.Windows.Forms.Label();
            this.delAcc_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connStr_label
            // 
            this.connStr_label.AutoSize = true;
            this.connStr_label.Location = new System.Drawing.Point(13, 13);
            this.connStr_label.Name = "connStr_label";
            this.connStr_label.Size = new System.Drawing.Size(94, 13);
            this.connStr_label.TabIndex = 0;
            this.connStr_label.Text = "Connection String:";
            // 
            // serverConnect_btn
            // 
            this.serverConnect_btn.Location = new System.Drawing.Point(373, 36);
            this.serverConnect_btn.Name = "serverConnect_btn";
            this.serverConnect_btn.Size = new System.Drawing.Size(75, 23);
            this.serverConnect_btn.TabIndex = 1;
            this.serverConnect_btn.Text = "Connect";
            this.serverConnect_btn.UseVisualStyleBackColor = true;
            this.serverConnect_btn.Click += new System.EventHandler(this.serverConnect_btn_Click);
            // 
            // serverDisconnect_btn
            // 
            this.serverDisconnect_btn.Enabled = false;
            this.serverDisconnect_btn.Location = new System.Drawing.Point(292, 36);
            this.serverDisconnect_btn.Name = "serverDisconnect_btn";
            this.serverDisconnect_btn.Size = new System.Drawing.Size(75, 23);
            this.serverDisconnect_btn.TabIndex = 2;
            this.serverDisconnect_btn.Text = "Disconnect";
            this.serverDisconnect_btn.UseVisualStyleBackColor = true;
            this.serverDisconnect_btn.Click += new System.EventHandler(this.serverDisconnect_btn_Click);
            // 
            // connStr_textbox
            // 
            this.connStr_textbox.Location = new System.Drawing.Point(113, 10);
            this.connStr_textbox.Name = "connStr_textbox";
            this.connStr_textbox.Size = new System.Drawing.Size(335, 20);
            this.connStr_textbox.TabIndex = 3;
            this.connStr_textbox.Text = "Data Source=DESKTOP-UBFOCHF;Initial Catalog=FinManDB;Integrated Security=True";
            // 
            // serverStat_label
            // 
            this.serverStat_label.AutoSize = true;
            this.serverStat_label.Location = new System.Drawing.Point(110, 41);
            this.serverStat_label.Name = "serverStat_label";
            this.serverStat_label.Size = new System.Drawing.Size(38, 13);
            this.serverStat_label.TabIndex = 4;
            this.serverStat_label.Text = "status:";
            // 
            // serverStat_status
            // 
            this.serverStat_status.AutoSize = true;
            this.serverStat_status.Location = new System.Drawing.Point(152, 41);
            this.serverStat_status.Name = "serverStat_status";
            this.serverStat_status.Size = new System.Drawing.Size(71, 13);
            this.serverStat_status.TabIndex = 5;
            this.serverStat_status.Text = "disconnected";
            // 
            // usrCred_label
            // 
            this.usrCred_label.AutoSize = true;
            this.usrCred_label.Location = new System.Drawing.Point(16, 101);
            this.usrCred_label.Name = "usrCred_label";
            this.usrCred_label.Size = new System.Drawing.Size(84, 13);
            this.usrCred_label.TabIndex = 6;
            this.usrCred_label.Text = "User Credentials";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(42, 132);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(58, 13);
            this.username_label.TabIndex = 7;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(42, 160);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "Password:";
            // 
            // username_textbox
            // 
            this.username_textbox.Enabled = false;
            this.username_textbox.Location = new System.Drawing.Point(113, 129);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(133, 20);
            this.username_textbox.TabIndex = 9;
            // 
            // password_textbox
            // 
            this.password_textbox.Enabled = false;
            this.password_textbox.Location = new System.Drawing.Point(113, 157);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(133, 20);
            this.password_textbox.TabIndex = 10;
            // 
            // admin_chkbox
            // 
            this.admin_chkbox.AutoSize = true;
            this.admin_chkbox.Enabled = false;
            this.admin_chkbox.Location = new System.Drawing.Point(267, 131);
            this.admin_chkbox.Name = "admin_chkbox";
            this.admin_chkbox.Size = new System.Drawing.Size(54, 17);
            this.admin_chkbox.TabIndex = 11;
            this.admin_chkbox.Text = "admin";
            this.admin_chkbox.UseVisualStyleBackColor = true;
            // 
            // signup_chkbox
            // 
            this.signup_chkbox.AutoSize = true;
            this.signup_chkbox.Enabled = false;
            this.signup_chkbox.Location = new System.Drawing.Point(113, 100);
            this.signup_chkbox.Name = "signup_chkbox";
            this.signup_chkbox.Size = new System.Drawing.Size(69, 17);
            this.signup_chkbox.TabIndex = 12;
            this.signup_chkbox.Text = "new user";
            this.signup_chkbox.UseVisualStyleBackColor = true;
            this.signup_chkbox.CheckedChanged += new System.EventHandler(this.signup_chkbox_CheckedChanged);
            // 
            // signin_btn
            // 
            this.signin_btn.Enabled = false;
            this.signin_btn.Location = new System.Drawing.Point(188, 208);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(75, 23);
            this.signin_btn.TabIndex = 13;
            this.signin_btn.Text = "Sign In";
            this.signin_btn.UseVisualStyleBackColor = true;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(267, 208);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 14;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Visible = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signout_btn
            // 
            this.signout_btn.Enabled = false;
            this.signout_btn.Location = new System.Drawing.Point(107, 208);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(75, 23);
            this.signout_btn.TabIndex = 15;
            this.signout_btn.Text = "Sign Out";
            this.signout_btn.UseVisualStyleBackColor = true;
            this.signout_btn.Click += new System.EventHandler(this.signout_btn_Click);
            // 
            // forgotPwd_link
            // 
            this.forgotPwd_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.forgotPwd_link.AutoSize = true;
            this.forgotPwd_link.Enabled = false;
            this.forgotPwd_link.LinkColor = System.Drawing.Color.Black;
            this.forgotPwd_link.Location = new System.Drawing.Point(266, 160);
            this.forgotPwd_link.Name = "forgotPwd_link";
            this.forgotPwd_link.Size = new System.Drawing.Size(88, 13);
            this.forgotPwd_link.TabIndex = 16;
            this.forgotPwd_link.TabStop = true;
            this.forgotPwd_link.Text = "forgot password?";
            this.forgotPwd_link.VisitedLinkColor = System.Drawing.Color.Black;
            this.forgotPwd_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPwd_link_LinkClicked);
            // 
            // loginStat_label
            // 
            this.loginStat_label.AutoSize = true;
            this.loginStat_label.Location = new System.Drawing.Point(42, 186);
            this.loginStat_label.Name = "loginStat_label";
            this.loginStat_label.Size = new System.Drawing.Size(38, 13);
            this.loginStat_label.TabIndex = 17;
            this.loginStat_label.Text = "status:";
            // 
            // loginStat_status
            // 
            this.loginStat_status.AutoSize = true;
            this.loginStat_status.Location = new System.Drawing.Point(86, 186);
            this.loginStat_status.Name = "loginStat_status";
            this.loginStat_status.Size = new System.Drawing.Size(56, 13);
            this.loginStat_status.TabIndex = 18;
            this.loginStat_status.Text = "signed out";
            // 
            // delAcc_btn
            // 
            this.delAcc_btn.Location = new System.Drawing.Point(348, 208);
            this.delAcc_btn.Name = "delAcc_btn";
            this.delAcc_btn.Size = new System.Drawing.Size(101, 23);
            this.delAcc_btn.TabIndex = 19;
            this.delAcc_btn.Text = "Delete Account";
            this.delAcc_btn.UseVisualStyleBackColor = true;
            this.delAcc_btn.Visible = false;
            this.delAcc_btn.Click += new System.EventHandler(this.delAcc_btn_Click);
            // 
            // ConnectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.delAcc_btn);
            this.Controls.Add(this.loginStat_status);
            this.Controls.Add(this.loginStat_label);
            this.Controls.Add(this.forgotPwd_link);
            this.Controls.Add(this.signout_btn);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.signup_chkbox);
            this.Controls.Add(this.admin_chkbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.usrCred_label);
            this.Controls.Add(this.serverStat_status);
            this.Controls.Add(this.serverStat_label);
            this.Controls.Add(this.connStr_textbox);
            this.Controls.Add(this.serverDisconnect_btn);
            this.Controls.Add(this.serverConnect_btn);
            this.Controls.Add(this.connStr_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connStr_label;
        private System.Windows.Forms.Button serverConnect_btn;
        private System.Windows.Forms.Button serverDisconnect_btn;
        private System.Windows.Forms.TextBox connStr_textbox;
        private System.Windows.Forms.Label serverStat_label;
        private System.Windows.Forms.Label serverStat_status;
        private System.Windows.Forms.Label usrCred_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.CheckBox admin_chkbox;
        private System.Windows.Forms.CheckBox signup_chkbox;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button signout_btn;
        private System.Windows.Forms.LinkLabel forgotPwd_link;
        private System.Windows.Forms.Label loginStat_label;
        private System.Windows.Forms.Label loginStat_status;
        private System.Windows.Forms.Button delAcc_btn;
    }
}