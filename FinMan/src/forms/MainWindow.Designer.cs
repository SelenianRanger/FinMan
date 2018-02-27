namespace FinMan.forms
{
    partial class MainWindow
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
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.settings_menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tran_gridview = new System.Windows.Forms.DataGridView();
            this.view_btn = new System.Windows.Forms.Button();
            this.delTran_btn = new System.Windows.Forms.Button();
            this.editTran_btn = new System.Windows.Forms.Button();
            this.addTran_btn = new System.Windows.Forms.Button();
            this.tran_label = new System.Windows.Forms.Label();
            this.admin_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.balance_balance = new System.Windows.Forms.Label();
            this.balance_label = new System.Windows.Forms.Label();
            this.accounts_label = new System.Windows.Forms.Label();
            this.editAcc_btn = new System.Windows.Forms.Button();
            this.acc_gridview = new System.Windows.Forms.DataGridView();
            this.finMan_label = new System.Windows.Forms.Label();
            this.mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tran_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings_menuitem});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(932, 24);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "Mainmenu";
            // 
            // settings_menuitem
            // 
            this.settings_menuitem.Name = "settings_menuitem";
            this.settings_menuitem.Size = new System.Drawing.Size(61, 20);
            this.settings_menuitem.Text = "Settings";
            this.settings_menuitem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tran_gridview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.view_btn);
            this.splitContainer1.Panel2.Controls.Add(this.delTran_btn);
            this.splitContainer1.Panel2.Controls.Add(this.editTran_btn);
            this.splitContainer1.Panel2.Controls.Add(this.addTran_btn);
            this.splitContainer1.Panel2.Controls.Add(this.tran_label);
            this.splitContainer1.Panel2.Controls.Add(this.admin_btn);
            this.splitContainer1.Panel2.Controls.Add(this.refresh_btn);
            this.splitContainer1.Panel2.Controls.Add(this.balance_balance);
            this.splitContainer1.Panel2.Controls.Add(this.balance_label);
            this.splitContainer1.Panel2.Controls.Add(this.accounts_label);
            this.splitContainer1.Panel2.Controls.Add(this.editAcc_btn);
            this.splitContainer1.Panel2.Controls.Add(this.acc_gridview);
            this.splitContainer1.Panel2.Controls.Add(this.finMan_label);
            this.splitContainer1.Size = new System.Drawing.Size(932, 550);
            this.splitContainer1.SplitterDistance = 637;
            this.splitContainer1.TabIndex = 1;
            // 
            // tran_gridview
            // 
            this.tran_gridview.AllowUserToAddRows = false;
            this.tran_gridview.AllowUserToDeleteRows = false;
            this.tran_gridview.AllowUserToResizeRows = false;
            this.tran_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tran_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tran_gridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tran_gridview.Location = new System.Drawing.Point(0, 0);
            this.tran_gridview.MultiSelect = false;
            this.tran_gridview.Name = "tran_gridview";
            this.tran_gridview.ReadOnly = true;
            this.tran_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tran_gridview.Size = new System.Drawing.Size(637, 550);
            this.tran_gridview.TabIndex = 0;
            this.tran_gridview.TabStop = false;
            this.tran_gridview.SelectionChanged += new System.EventHandler(this.tran_gridview_RowSelection);
            // 
            // view_btn
            // 
            this.view_btn.Enabled = false;
            this.view_btn.Location = new System.Drawing.Point(10, 463);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(75, 48);
            this.view_btn.TabIndex = 12;
            this.view_btn.Text = "Edit View";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // delTran_btn
            // 
            this.delTran_btn.Enabled = false;
            this.delTran_btn.Location = new System.Drawing.Point(190, 432);
            this.delTran_btn.Name = "delTran_btn";
            this.delTran_btn.Size = new System.Drawing.Size(75, 23);
            this.delTran_btn.TabIndex = 11;
            this.delTran_btn.Text = "Remove";
            this.delTran_btn.UseVisualStyleBackColor = true;
            this.delTran_btn.Click += new System.EventHandler(this.delTran_btn_Click);
            // 
            // editTran_btn
            // 
            this.editTran_btn.Enabled = false;
            this.editTran_btn.Location = new System.Drawing.Point(190, 380);
            this.editTran_btn.Name = "editTran_btn";
            this.editTran_btn.Size = new System.Drawing.Size(75, 23);
            this.editTran_btn.TabIndex = 10;
            this.editTran_btn.Text = "Edit";
            this.editTran_btn.UseVisualStyleBackColor = true;
            this.editTran_btn.Click += new System.EventHandler(this.editTran_btn_Click);
            // 
            // addTran_btn
            // 
            this.addTran_btn.Enabled = false;
            this.addTran_btn.Location = new System.Drawing.Point(190, 351);
            this.addTran_btn.Name = "addTran_btn";
            this.addTran_btn.Size = new System.Drawing.Size(75, 23);
            this.addTran_btn.TabIndex = 9;
            this.addTran_btn.Text = "Add";
            this.addTran_btn.UseVisualStyleBackColor = true;
            this.addTran_btn.Click += new System.EventHandler(this.addTran_btn_Click);
            // 
            // tran_label
            // 
            this.tran_label.AutoSize = true;
            this.tran_label.Location = new System.Drawing.Point(167, 323);
            this.tran_label.Name = "tran_label";
            this.tran_label.Size = new System.Drawing.Size(110, 13);
            this.tran_label.TabIndex = 8;
            this.tran_label.Text = "------ Transactions ------";
            this.tran_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(92, 253);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(115, 31);
            this.admin_btn.TabIndex = 7;
            this.admin_btn.Text = "Admin Tools";
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Visible = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Enabled = false;
            this.refresh_btn.Location = new System.Drawing.Point(10, 517);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // balance_balance
            // 
            this.balance_balance.AutoSize = true;
            this.balance_balance.Location = new System.Drawing.Point(215, 151);
            this.balance_balance.Name = "balance_balance";
            this.balance_balance.Size = new System.Drawing.Size(0, 13);
            this.balance_balance.TabIndex = 5;
            this.balance_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.Location = new System.Drawing.Point(190, 135);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(76, 13);
            this.balance_label.TabIndex = 4;
            this.balance_label.Text = "Total Balance:";
            // 
            // accounts_label
            // 
            this.accounts_label.AutoSize = true;
            this.accounts_label.Location = new System.Drawing.Point(206, 80);
            this.accounts_label.Name = "accounts_label";
            this.accounts_label.Size = new System.Drawing.Size(64, 13);
            this.accounts_label.TabIndex = 3;
            this.accounts_label.Text = "- Accounts -";
            this.accounts_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editAcc_btn
            // 
            this.editAcc_btn.Enabled = false;
            this.editAcc_btn.Location = new System.Drawing.Point(193, 212);
            this.editAcc_btn.Name = "editAcc_btn";
            this.editAcc_btn.Size = new System.Drawing.Size(88, 23);
            this.editAcc_btn.TabIndex = 2;
            this.editAcc_btn.Text = "Edit Accounts";
            this.editAcc_btn.UseVisualStyleBackColor = true;
            this.editAcc_btn.Click += new System.EventHandler(this.editAcc_btn_Click);
            // 
            // acc_gridview
            // 
            this.acc_gridview.AllowUserToAddRows = false;
            this.acc_gridview.AllowUserToDeleteRows = false;
            this.acc_gridview.AllowUserToResizeRows = false;
            this.acc_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.acc_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.acc_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acc_gridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.acc_gridview.Location = new System.Drawing.Point(3, 85);
            this.acc_gridview.MultiSelect = false;
            this.acc_gridview.Name = "acc_gridview";
            this.acc_gridview.ReadOnly = true;
            this.acc_gridview.Size = new System.Drawing.Size(181, 150);
            this.acc_gridview.TabIndex = 1;
            // 
            // finMan_label
            // 
            this.finMan_label.AutoSize = true;
            this.finMan_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.finMan_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.finMan_label.Location = new System.Drawing.Point(84, 6);
            this.finMan_label.Name = "finMan_label";
            this.finMan_label.Size = new System.Drawing.Size(137, 39);
            this.finMan_label.TabIndex = 0;
            this.finMan_label.Text = "FinMan";
            this.finMan_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 574);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainmenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Sina Kamali [610394126]";
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tran_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem settings_menuitem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView tran_gridview;
        private System.Windows.Forms.Label finMan_label;
        private System.Windows.Forms.Label balance_balance;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Label accounts_label;
        private System.Windows.Forms.Button editAcc_btn;
        private System.Windows.Forms.DataGridView acc_gridview;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Button delTran_btn;
        private System.Windows.Forms.Button editTran_btn;
        private System.Windows.Forms.Button addTran_btn;
        private System.Windows.Forms.Label tran_label;
    }
}