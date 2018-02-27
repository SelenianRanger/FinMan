namespace FinMan.forms
{
    partial class AdminWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.upper_split = new System.Windows.Forms.SplitContainer();
            this.acc_gridview = new System.Windows.Forms.DataGridView();
            this.acc_label = new System.Windows.Forms.Label();
            this.refrsh_btn = new System.Windows.Forms.Button();
            this.accDel_btn = new System.Windows.Forms.Button();
            this.accEdit_btn = new System.Windows.Forms.Button();
            this.accAdd_btn = new System.Windows.Forms.Button();
            this.lower_split = new System.Windows.Forms.SplitContainer();
            this.lowerLeft_split = new System.Windows.Forms.SplitContainer();
            this.inc_gridview = new System.Windows.Forms.DataGridView();
            this.inc_label = new System.Windows.Forms.Label();
            this.incDel_btn = new System.Windows.Forms.Button();
            this.incEdit_btn = new System.Windows.Forms.Button();
            this.incAdd_btn = new System.Windows.Forms.Button();
            this.lowerRight_split = new System.Windows.Forms.SplitContainer();
            this.exp_label = new System.Windows.Forms.Label();
            this.expDel_btn = new System.Windows.Forms.Button();
            this.expEdit_btn = new System.Windows.Forms.Button();
            this.expAdd_btn = new System.Windows.Forms.Button();
            this.exp_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upper_split)).BeginInit();
            this.upper_split.Panel1.SuspendLayout();
            this.upper_split.Panel2.SuspendLayout();
            this.upper_split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower_split)).BeginInit();
            this.lower_split.Panel1.SuspendLayout();
            this.lower_split.Panel2.SuspendLayout();
            this.lower_split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLeft_split)).BeginInit();
            this.lowerLeft_split.Panel1.SuspendLayout();
            this.lowerLeft_split.Panel2.SuspendLayout();
            this.lowerLeft_split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inc_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerRight_split)).BeginInit();
            this.lowerRight_split.Panel1.SuspendLayout();
            this.lowerRight_split.Panel2.SuspendLayout();
            this.lowerRight_split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.upper_split);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lower_split);
            this.splitContainer1.Size = new System.Drawing.Size(654, 503);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
            // 
            // upper_split
            // 
            this.upper_split.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.upper_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upper_split.Location = new System.Drawing.Point(0, 0);
            this.upper_split.Name = "upper_split";
            // 
            // upper_split.Panel1
            // 
            this.upper_split.Panel1.Controls.Add(this.acc_gridview);
            // 
            // upper_split.Panel2
            // 
            this.upper_split.Panel2.Controls.Add(this.acc_label);
            this.upper_split.Panel2.Controls.Add(this.refrsh_btn);
            this.upper_split.Panel2.Controls.Add(this.accDel_btn);
            this.upper_split.Panel2.Controls.Add(this.accEdit_btn);
            this.upper_split.Panel2.Controls.Add(this.accAdd_btn);
            this.upper_split.Size = new System.Drawing.Size(654, 302);
            this.upper_split.SplitterDistance = 568;
            this.upper_split.TabIndex = 0;
            // 
            // acc_gridview
            // 
            this.acc_gridview.AllowUserToAddRows = false;
            this.acc_gridview.AllowUserToDeleteRows = false;
            this.acc_gridview.AllowUserToOrderColumns = true;
            this.acc_gridview.AllowUserToResizeRows = false;
            this.acc_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.acc_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acc_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acc_gridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.acc_gridview.Location = new System.Drawing.Point(0, 0);
            this.acc_gridview.MultiSelect = false;
            this.acc_gridview.Name = "acc_gridview";
            this.acc_gridview.ReadOnly = true;
            this.acc_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.acc_gridview.Size = new System.Drawing.Size(564, 298);
            this.acc_gridview.TabIndex = 0;
            this.acc_gridview.SelectionChanged += new System.EventHandler(this.acc_gridview_RowSelection);
            // 
            // acc_label
            // 
            this.acc_label.AutoSize = true;
            this.acc_label.Location = new System.Drawing.Point(1, 18);
            this.acc_label.Name = "acc_label";
            this.acc_label.Size = new System.Drawing.Size(79, 13);
            this.acc_label.TabIndex = 4;
            this.acc_label.Text = "Account Types";
            this.acc_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refrsh_btn
            // 
            this.refrsh_btn.Location = new System.Drawing.Point(2, 272);
            this.refrsh_btn.Name = "refrsh_btn";
            this.refrsh_btn.Size = new System.Drawing.Size(75, 23);
            this.refrsh_btn.TabIndex = 3;
            this.refrsh_btn.Text = "Refresh";
            this.refrsh_btn.UseVisualStyleBackColor = true;
            this.refrsh_btn.Click += new System.EventHandler(this.refrsh_btn_Click);
            // 
            // accDel_btn
            // 
            this.accDel_btn.Enabled = false;
            this.accDel_btn.Location = new System.Drawing.Point(2, 132);
            this.accDel_btn.Name = "accDel_btn";
            this.accDel_btn.Size = new System.Drawing.Size(75, 23);
            this.accDel_btn.TabIndex = 2;
            this.accDel_btn.Text = "Remove";
            this.accDel_btn.UseVisualStyleBackColor = true;
            this.accDel_btn.Click += new System.EventHandler(this.accDel_btn_Click);
            // 
            // accEdit_btn
            // 
            this.accEdit_btn.Enabled = false;
            this.accEdit_btn.Location = new System.Drawing.Point(2, 67);
            this.accEdit_btn.Name = "accEdit_btn";
            this.accEdit_btn.Size = new System.Drawing.Size(75, 23);
            this.accEdit_btn.TabIndex = 1;
            this.accEdit_btn.Text = "Edit";
            this.accEdit_btn.UseVisualStyleBackColor = true;
            this.accEdit_btn.Click += new System.EventHandler(this.accEdit_btn_Click);
            // 
            // accAdd_btn
            // 
            this.accAdd_btn.Location = new System.Drawing.Point(2, 38);
            this.accAdd_btn.Name = "accAdd_btn";
            this.accAdd_btn.Size = new System.Drawing.Size(75, 23);
            this.accAdd_btn.TabIndex = 0;
            this.accAdd_btn.Text = "Add";
            this.accAdd_btn.UseVisualStyleBackColor = true;
            this.accAdd_btn.Click += new System.EventHandler(this.accAdd_btn_Click);
            // 
            // lower_split
            // 
            this.lower_split.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lower_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lower_split.Location = new System.Drawing.Point(0, 0);
            this.lower_split.Name = "lower_split";
            // 
            // lower_split.Panel1
            // 
            this.lower_split.Panel1.Controls.Add(this.lowerLeft_split);
            // 
            // lower_split.Panel2
            // 
            this.lower_split.Panel2.Controls.Add(this.lowerRight_split);
            this.lower_split.Size = new System.Drawing.Size(654, 197);
            this.lower_split.SplitterDistance = 319;
            this.lower_split.TabIndex = 0;
            // 
            // lowerLeft_split
            // 
            this.lowerLeft_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerLeft_split.Location = new System.Drawing.Point(0, 0);
            this.lowerLeft_split.Name = "lowerLeft_split";
            // 
            // lowerLeft_split.Panel1
            // 
            this.lowerLeft_split.Panel1.Controls.Add(this.inc_gridview);
            // 
            // lowerLeft_split.Panel2
            // 
            this.lowerLeft_split.Panel2.Controls.Add(this.inc_label);
            this.lowerLeft_split.Panel2.Controls.Add(this.incDel_btn);
            this.lowerLeft_split.Panel2.Controls.Add(this.incEdit_btn);
            this.lowerLeft_split.Panel2.Controls.Add(this.incAdd_btn);
            this.lowerLeft_split.Size = new System.Drawing.Size(315, 193);
            this.lowerLeft_split.SplitterDistance = 229;
            this.lowerLeft_split.TabIndex = 0;
            // 
            // inc_gridview
            // 
            this.inc_gridview.AllowUserToAddRows = false;
            this.inc_gridview.AllowUserToDeleteRows = false;
            this.inc_gridview.AllowUserToOrderColumns = true;
            this.inc_gridview.AllowUserToResizeRows = false;
            this.inc_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inc_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inc_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inc_gridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inc_gridview.Location = new System.Drawing.Point(0, 0);
            this.inc_gridview.MultiSelect = false;
            this.inc_gridview.Name = "inc_gridview";
            this.inc_gridview.ReadOnly = true;
            this.inc_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inc_gridview.Size = new System.Drawing.Size(229, 193);
            this.inc_gridview.TabIndex = 0;
            this.inc_gridview.SelectionChanged += new System.EventHandler(this.inc_gridview_RowSelection);
            // 
            // inc_label
            // 
            this.inc_label.AutoSize = true;
            this.inc_label.Location = new System.Drawing.Point(4, 10);
            this.inc_label.Name = "inc_label";
            this.inc_label.Size = new System.Drawing.Size(74, 13);
            this.inc_label.TabIndex = 3;
            this.inc_label.Text = "Income Types";
            // 
            // incDel_btn
            // 
            this.incDel_btn.Enabled = false;
            this.incDel_btn.Location = new System.Drawing.Point(4, 126);
            this.incDel_btn.Name = "incDel_btn";
            this.incDel_btn.Size = new System.Drawing.Size(75, 23);
            this.incDel_btn.TabIndex = 2;
            this.incDel_btn.Text = "Remove";
            this.incDel_btn.UseVisualStyleBackColor = true;
            this.incDel_btn.Click += new System.EventHandler(this.incDel_btn_Click);
            // 
            // incEdit_btn
            // 
            this.incEdit_btn.Enabled = false;
            this.incEdit_btn.Location = new System.Drawing.Point(4, 62);
            this.incEdit_btn.Name = "incEdit_btn";
            this.incEdit_btn.Size = new System.Drawing.Size(75, 23);
            this.incEdit_btn.TabIndex = 1;
            this.incEdit_btn.Text = "Edit";
            this.incEdit_btn.UseVisualStyleBackColor = true;
            this.incEdit_btn.Click += new System.EventHandler(this.incEdit_btn_Click);
            // 
            // incAdd_btn
            // 
            this.incAdd_btn.Location = new System.Drawing.Point(4, 34);
            this.incAdd_btn.Name = "incAdd_btn";
            this.incAdd_btn.Size = new System.Drawing.Size(75, 23);
            this.incAdd_btn.TabIndex = 0;
            this.incAdd_btn.Text = "Add";
            this.incAdd_btn.UseVisualStyleBackColor = true;
            this.incAdd_btn.Click += new System.EventHandler(this.incAdd_btn_Click);
            // 
            // lowerRight_split
            // 
            this.lowerRight_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerRight_split.Location = new System.Drawing.Point(0, 0);
            this.lowerRight_split.Name = "lowerRight_split";
            // 
            // lowerRight_split.Panel1
            // 
            this.lowerRight_split.Panel1.Controls.Add(this.exp_label);
            this.lowerRight_split.Panel1.Controls.Add(this.expDel_btn);
            this.lowerRight_split.Panel1.Controls.Add(this.expEdit_btn);
            this.lowerRight_split.Panel1.Controls.Add(this.expAdd_btn);
            // 
            // lowerRight_split.Panel2
            // 
            this.lowerRight_split.Panel2.Controls.Add(this.exp_gridview);
            this.lowerRight_split.Size = new System.Drawing.Size(327, 193);
            this.lowerRight_split.SplitterDistance = 81;
            this.lowerRight_split.TabIndex = 0;
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.Location = new System.Drawing.Point(2, 10);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(80, 13);
            this.exp_label.TabIndex = 3;
            this.exp_label.Text = "Expense Types";
            // 
            // expDel_btn
            // 
            this.expDel_btn.Enabled = false;
            this.expDel_btn.Location = new System.Drawing.Point(3, 127);
            this.expDel_btn.Name = "expDel_btn";
            this.expDel_btn.Size = new System.Drawing.Size(75, 23);
            this.expDel_btn.TabIndex = 2;
            this.expDel_btn.Text = "Remove";
            this.expDel_btn.UseVisualStyleBackColor = true;
            this.expDel_btn.Click += new System.EventHandler(this.expDel_btn_Click);
            // 
            // expEdit_btn
            // 
            this.expEdit_btn.Enabled = false;
            this.expEdit_btn.Location = new System.Drawing.Point(3, 63);
            this.expEdit_btn.Name = "expEdit_btn";
            this.expEdit_btn.Size = new System.Drawing.Size(75, 23);
            this.expEdit_btn.TabIndex = 1;
            this.expEdit_btn.Text = "Edit";
            this.expEdit_btn.UseVisualStyleBackColor = true;
            this.expEdit_btn.Click += new System.EventHandler(this.expEdit_btn_Click);
            // 
            // expAdd_btn
            // 
            this.expAdd_btn.Location = new System.Drawing.Point(3, 34);
            this.expAdd_btn.Name = "expAdd_btn";
            this.expAdd_btn.Size = new System.Drawing.Size(75, 23);
            this.expAdd_btn.TabIndex = 0;
            this.expAdd_btn.Text = "Add";
            this.expAdd_btn.UseVisualStyleBackColor = true;
            this.expAdd_btn.Click += new System.EventHandler(this.expAdd_btn_Click);
            // 
            // exp_gridview
            // 
            this.exp_gridview.AllowUserToAddRows = false;
            this.exp_gridview.AllowUserToDeleteRows = false;
            this.exp_gridview.AllowUserToOrderColumns = true;
            this.exp_gridview.AllowUserToResizeRows = false;
            this.exp_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.exp_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exp_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exp_gridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.exp_gridview.Location = new System.Drawing.Point(0, 0);
            this.exp_gridview.MultiSelect = false;
            this.exp_gridview.Name = "exp_gridview";
            this.exp_gridview.ReadOnly = true;
            this.exp_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exp_gridview.Size = new System.Drawing.Size(242, 193);
            this.exp_gridview.TabIndex = 0;
            this.exp_gridview.SelectionChanged += new System.EventHandler(this.exp_gridview_RowSelection);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 503);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Tools";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.upper_split.Panel1.ResumeLayout(false);
            this.upper_split.Panel2.ResumeLayout(false);
            this.upper_split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upper_split)).EndInit();
            this.upper_split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acc_gridview)).EndInit();
            this.lower_split.Panel1.ResumeLayout(false);
            this.lower_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lower_split)).EndInit();
            this.lower_split.ResumeLayout(false);
            this.lowerLeft_split.Panel1.ResumeLayout(false);
            this.lowerLeft_split.Panel2.ResumeLayout(false);
            this.lowerLeft_split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLeft_split)).EndInit();
            this.lowerLeft_split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inc_gridview)).EndInit();
            this.lowerRight_split.Panel1.ResumeLayout(false);
            this.lowerRight_split.Panel1.PerformLayout();
            this.lowerRight_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lowerRight_split)).EndInit();
            this.lowerRight_split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exp_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer upper_split;
        private System.Windows.Forms.DataGridView acc_gridview;
        private System.Windows.Forms.Label acc_label;
        private System.Windows.Forms.Button refrsh_btn;
        private System.Windows.Forms.Button accDel_btn;
        private System.Windows.Forms.Button accEdit_btn;
        private System.Windows.Forms.Button accAdd_btn;
        private System.Windows.Forms.SplitContainer lower_split;
        private System.Windows.Forms.SplitContainer lowerLeft_split;
        private System.Windows.Forms.DataGridView inc_gridview;
        private System.Windows.Forms.Label inc_label;
        private System.Windows.Forms.Button incDel_btn;
        private System.Windows.Forms.Button incEdit_btn;
        private System.Windows.Forms.Button incAdd_btn;
        private System.Windows.Forms.SplitContainer lowerRight_split;
        private System.Windows.Forms.Label exp_label;
        private System.Windows.Forms.Button expDel_btn;
        private System.Windows.Forms.Button expEdit_btn;
        private System.Windows.Forms.Button expAdd_btn;
        private System.Windows.Forms.DataGridView exp_gridview;
    }
}