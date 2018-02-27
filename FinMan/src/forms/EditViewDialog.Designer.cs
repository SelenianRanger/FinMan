namespace FinMan.forms
{
    partial class EditViewDialog
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.inc_chklistbox = new System.Windows.Forms.CheckedListBox();
            this.exp_chklistbox = new System.Windows.Forms.CheckedListBox();
            this.date_chkbox = new System.Windows.Forms.CheckBox();
            this.to_datepicker = new System.Windows.Forms.DateTimePicker();
            this.from_datepicker = new System.Windows.Forms.DateTimePicker();
            this.to_label = new System.Windows.Forms.Label();
            this.from_label = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.exp_label = new System.Windows.Forms.Label();
            this.inc_label = new System.Windows.Forms.Label();
            this.stat_label = new System.Windows.Forms.Label();
            this.stat_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.stat_status);
            this.splitContainer1.Panel2.Controls.Add(this.stat_label);
            this.splitContainer1.Panel2.Controls.Add(this.date_chkbox);
            this.splitContainer1.Panel2.Controls.Add(this.to_datepicker);
            this.splitContainer1.Panel2.Controls.Add(this.from_datepicker);
            this.splitContainer1.Panel2.Controls.Add(this.to_label);
            this.splitContainer1.Panel2.Controls.Add(this.from_label);
            this.splitContainer1.Panel2.Controls.Add(this.done_btn);
            this.splitContainer1.Panel2.Controls.Add(this.cancel_btn);
            this.splitContainer1.Size = new System.Drawing.Size(483, 221);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.inc_label);
            this.splitContainer2.Panel1.Controls.Add(this.inc_chklistbox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.exp_label);
            this.splitContainer2.Panel2.Controls.Add(this.exp_chklistbox);
            this.splitContainer2.Size = new System.Drawing.Size(483, 106);
            this.splitContainer2.SplitterDistance = 233;
            this.splitContainer2.TabIndex = 0;
            // 
            // inc_chklistbox
            // 
            this.inc_chklistbox.CheckOnClick = true;
            this.inc_chklistbox.FormattingEnabled = true;
            this.inc_chklistbox.Location = new System.Drawing.Point(3, 23);
            this.inc_chklistbox.Name = "inc_chklistbox";
            this.inc_chklistbox.Size = new System.Drawing.Size(226, 79);
            this.inc_chklistbox.TabIndex = 0;
            // 
            // exp_chklistbox
            // 
            this.exp_chklistbox.CheckOnClick = true;
            this.exp_chklistbox.FormattingEnabled = true;
            this.exp_chklistbox.Location = new System.Drawing.Point(-2, 23);
            this.exp_chklistbox.Name = "exp_chklistbox";
            this.exp_chklistbox.Size = new System.Drawing.Size(246, 79);
            this.exp_chklistbox.TabIndex = 0;
            // 
            // date_chkbox
            // 
            this.date_chkbox.AutoSize = true;
            this.date_chkbox.Location = new System.Drawing.Point(19, 12);
            this.date_chkbox.Name = "date_chkbox";
            this.date_chkbox.Size = new System.Drawing.Size(74, 17);
            this.date_chkbox.TabIndex = 6;
            this.date_chkbox.Text = "Date Filter";
            this.date_chkbox.UseVisualStyleBackColor = true;
            this.date_chkbox.CheckedChanged += new System.EventHandler(this.date_chkbox_CheckedChanged);
            // 
            // to_datepicker
            // 
            this.to_datepicker.CustomFormat = "dd/MM/yy    -    hh:mm tt ";
            this.to_datepicker.Enabled = false;
            this.to_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to_datepicker.Location = new System.Drawing.Point(55, 64);
            this.to_datepicker.Name = "to_datepicker";
            this.to_datepicker.ShowUpDown = true;
            this.to_datepicker.Size = new System.Drawing.Size(200, 20);
            this.to_datepicker.TabIndex = 5;
            // 
            // from_datepicker
            // 
            this.from_datepicker.CustomFormat = "dd/MM/yy    -    hh:mm tt ";
            this.from_datepicker.Enabled = false;
            this.from_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_datepicker.Location = new System.Drawing.Point(55, 34);
            this.from_datepicker.Name = "from_datepicker";
            this.from_datepicker.ShowUpDown = true;
            this.from_datepicker.Size = new System.Drawing.Size(200, 20);
            this.from_datepicker.TabIndex = 4;
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(30, 67);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(19, 13);
            this.to_label.TabIndex = 3;
            this.to_label.Text = "to:";
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.Location = new System.Drawing.Point(19, 37);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(30, 13);
            this.from_label.TabIndex = 2;
            this.from_label.Text = "from:";
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(394, 12);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(75, 23);
            this.done_btn.TabIndex = 1;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(394, 41);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.Location = new System.Drawing.Point(4, 4);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(83, 13);
            this.exp_label.TabIndex = 1;
            this.exp_label.Text = "Expense Types:";
            // 
            // inc_label
            // 
            this.inc_label.AutoSize = true;
            this.inc_label.Location = new System.Drawing.Point(4, 4);
            this.inc_label.Name = "inc_label";
            this.inc_label.Size = new System.Drawing.Size(77, 13);
            this.inc_label.TabIndex = 1;
            this.inc_label.Text = "Income Types:";
            // 
            // stat_label
            // 
            this.stat_label.AutoSize = true;
            this.stat_label.Location = new System.Drawing.Point(264, 70);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(38, 13);
            this.stat_label.TabIndex = 7;
            this.stat_label.Text = "status:";
            // 
            // stat_status
            // 
            this.stat_status.AutoSize = true;
            this.stat_status.Location = new System.Drawing.Point(308, 70);
            this.stat_status.Name = "stat_status";
            this.stat_status.Size = new System.Drawing.Size(71, 13);
            this.stat_status.TabIndex = 8;
            this.stat_status.Text = "edit view filter";
            // 
            // EditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 221);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditViewDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit View";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckedListBox inc_chklistbox;
        private System.Windows.Forms.CheckedListBox exp_chklistbox;
        private System.Windows.Forms.CheckBox date_chkbox;
        private System.Windows.Forms.DateTimePicker to_datepicker;
        private System.Windows.Forms.DateTimePicker from_datepicker;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Label from_label;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label inc_label;
        private System.Windows.Forms.Label exp_label;
        private System.Windows.Forms.Label stat_status;
        private System.Windows.Forms.Label stat_label;
    }
}