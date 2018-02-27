namespace FinMan.forms
{
    partial class ForgotDialog
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
            this.username_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.pwd1_label = new System.Windows.Forms.Label();
            this.pwd2_label = new System.Windows.Forms.Label();
            this.pwd1_textbox = new System.Windows.Forms.TextBox();
            this.pwd2_textbox = new System.Windows.Forms.TextBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.stat_label = new System.Windows.Forms.Label();
            this.stat_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(17, 15);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(56, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "username:";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(79, 12);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(197, 10);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // pwd1_label
            // 
            this.pwd1_label.AutoSize = true;
            this.pwd1_label.Location = new System.Drawing.Point(17, 71);
            this.pwd1_label.Name = "pwd1_label";
            this.pwd1_label.Size = new System.Drawing.Size(78, 13);
            this.pwd1_label.TabIndex = 3;
            this.pwd1_label.Text = "new password:";
            this.pwd1_label.Visible = false;
            // 
            // pwd2_label
            // 
            this.pwd2_label.AutoSize = true;
            this.pwd2_label.Location = new System.Drawing.Point(17, 96);
            this.pwd2_label.Name = "pwd2_label";
            this.pwd2_label.Size = new System.Drawing.Size(88, 13);
            this.pwd2_label.TabIndex = 4;
            this.pwd2_label.Text = "repeat password:";
            this.pwd2_label.Visible = false;
            // 
            // pwd1_textbox
            // 
            this.pwd1_textbox.Location = new System.Drawing.Point(111, 68);
            this.pwd1_textbox.Name = "pwd1_textbox";
            this.pwd1_textbox.PasswordChar = '*';
            this.pwd1_textbox.Size = new System.Drawing.Size(100, 20);
            this.pwd1_textbox.TabIndex = 5;
            this.pwd1_textbox.Visible = false;
            this.pwd1_textbox.TextChanged += new System.EventHandler(this.pwd1_textbox_TextChanged);
            // 
            // pwd2_textbox
            // 
            this.pwd2_textbox.Location = new System.Drawing.Point(111, 93);
            this.pwd2_textbox.Name = "pwd2_textbox";
            this.pwd2_textbox.PasswordChar = '*';
            this.pwd2_textbox.Size = new System.Drawing.Size(100, 20);
            this.pwd2_textbox.TabIndex = 6;
            this.pwd2_textbox.Visible = false;
            this.pwd2_textbox.TextChanged += new System.EventHandler(this.pwd2_textbox_TextChanged);
            // 
            // done_btn
            // 
            this.done_btn.Enabled = false;
            this.done_btn.Location = new System.Drawing.Point(160, 130);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(112, 23);
            this.done_btn.TabIndex = 7;
            this.done_btn.Text = "Change Password";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // stat_label
            // 
            this.stat_label.AutoSize = true;
            this.stat_label.Location = new System.Drawing.Point(17, 44);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(38, 13);
            this.stat_label.TabIndex = 9;
            this.stat_label.Text = "status:";
            // 
            // stat_status
            // 
            this.stat_status.AutoSize = true;
            this.stat_status.Location = new System.Drawing.Point(58, 44);
            this.stat_status.Name = "stat_status";
            this.stat_status.Size = new System.Drawing.Size(80, 13);
            this.stat_status.TabIndex = 10;
            this.stat_status.Text = "enter username";
            // 
            // ForgotDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.stat_status);
            this.Controls.Add(this.stat_label);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.pwd2_textbox);
            this.Controls.Add(this.pwd1_textbox);
            this.Controls.Add(this.pwd2_label);
            this.Controls.Add(this.pwd1_label);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "password recovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label pwd1_label;
        private System.Windows.Forms.Label pwd2_label;
        private System.Windows.Forms.TextBox pwd1_textbox;
        private System.Windows.Forms.TextBox pwd2_textbox;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label stat_label;
        private System.Windows.Forms.Label stat_status;
    }
}