namespace FinMan.forms.Transaction
{
    partial class AddTransactionDialog
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
            this.acc_label = new System.Windows.Forms.Label();
            this.acc_combo = new System.Windows.Forms.ComboBox();
            this.type_groupbox = new System.Windows.Forms.GroupBox();
            this.deposit_radiobtn = new System.Windows.Forms.RadioButton();
            this.pay_radiobtn = new System.Windows.Forms.RadioButton();
            this.cat_label = new System.Windows.Forms.Label();
            this.cat_combo = new System.Windows.Forms.ComboBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.time_label = new System.Windows.Forms.Label();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.desc_label = new System.Windows.Forms.Label();
            this.desc_textbox = new System.Windows.Forms.TextBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.stat_label = new System.Windows.Forms.Label();
            this.stat_status = new System.Windows.Forms.Label();
            this.type_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // acc_label
            // 
            this.acc_label.AutoSize = true;
            this.acc_label.Location = new System.Drawing.Point(16, 25);
            this.acc_label.Name = "acc_label";
            this.acc_label.Size = new System.Drawing.Size(49, 13);
            this.acc_label.TabIndex = 0;
            this.acc_label.Text = "account:";
            // 
            // acc_combo
            // 
            this.acc_combo.FormattingEnabled = true;
            this.acc_combo.Location = new System.Drawing.Point(71, 22);
            this.acc_combo.Name = "acc_combo";
            this.acc_combo.Size = new System.Drawing.Size(121, 21);
            this.acc_combo.TabIndex = 1;
            // 
            // type_groupbox
            // 
            this.type_groupbox.Controls.Add(this.deposit_radiobtn);
            this.type_groupbox.Controls.Add(this.pay_radiobtn);
            this.type_groupbox.Location = new System.Drawing.Point(211, 12);
            this.type_groupbox.Name = "type_groupbox";
            this.type_groupbox.Size = new System.Drawing.Size(73, 71);
            this.type_groupbox.TabIndex = 2;
            this.type_groupbox.TabStop = false;
            this.type_groupbox.Text = "type";
            // 
            // deposit_radiobtn
            // 
            this.deposit_radiobtn.AutoSize = true;
            this.deposit_radiobtn.Location = new System.Drawing.Point(7, 44);
            this.deposit_radiobtn.Name = "deposit_radiobtn";
            this.deposit_radiobtn.Size = new System.Drawing.Size(59, 17);
            this.deposit_radiobtn.TabIndex = 1;
            this.deposit_radiobtn.Text = "deposit";
            this.deposit_radiobtn.UseVisualStyleBackColor = true;
            // 
            // pay_radiobtn
            // 
            this.pay_radiobtn.AutoSize = true;
            this.pay_radiobtn.Location = new System.Drawing.Point(7, 20);
            this.pay_radiobtn.Name = "pay_radiobtn";
            this.pay_radiobtn.Size = new System.Drawing.Size(42, 17);
            this.pay_radiobtn.TabIndex = 0;
            this.pay_radiobtn.Text = "pay";
            this.pay_radiobtn.UseVisualStyleBackColor = true;
            this.pay_radiobtn.CheckedChanged += new System.EventHandler(this.pay_radiobtn_CheckedChanged);
            // 
            // cat_label
            // 
            this.cat_label.AutoSize = true;
            this.cat_label.Location = new System.Drawing.Point(16, 60);
            this.cat_label.Name = "cat_label";
            this.cat_label.Size = new System.Drawing.Size(51, 13);
            this.cat_label.TabIndex = 3;
            this.cat_label.Text = "category:";
            // 
            // cat_combo
            // 
            this.cat_combo.FormattingEnabled = true;
            this.cat_combo.Location = new System.Drawing.Point(71, 57);
            this.cat_combo.Name = "cat_combo";
            this.cat_combo.Size = new System.Drawing.Size(121, 21);
            this.cat_combo.TabIndex = 4;
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(16, 113);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(45, 13);
            this.amount_label.TabIndex = 5;
            this.amount_label.Text = "amount:";
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(71, 110);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(100, 20);
            this.amount_textbox.TabIndex = 6;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(195, 113);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(29, 13);
            this.time_label.TabIndex = 7;
            this.time_label.Text = "time:";
            // 
            // date_picker
            // 
            this.date_picker.CustomFormat = "dd/MM/yy    -    hh:mm tt ";
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(236, 110);
            this.date_picker.Name = "date_picker";
            this.date_picker.ShowUpDown = true;
            this.date_picker.Size = new System.Drawing.Size(200, 20);
            this.date_picker.TabIndex = 8;
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Location = new System.Drawing.Point(19, 151);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(61, 13);
            this.desc_label.TabIndex = 9;
            this.desc_label.Text = "description:";
            // 
            // desc_textbox
            // 
            this.desc_textbox.Location = new System.Drawing.Point(19, 168);
            this.desc_textbox.Multiline = true;
            this.desc_textbox.Name = "desc_textbox";
            this.desc_textbox.Size = new System.Drawing.Size(211, 90);
            this.desc_textbox.TabIndex = 10;
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(343, 166);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(75, 23);
            this.done_btn.TabIndex = 11;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(343, 195);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // stat_label
            // 
            this.stat_label.AutoSize = true;
            this.stat_label.Location = new System.Drawing.Point(253, 245);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(38, 13);
            this.stat_label.TabIndex = 13;
            this.stat_label.Text = "status:";
            // 
            // stat_status
            // 
            this.stat_status.AutoSize = true;
            this.stat_status.Location = new System.Drawing.Point(299, 245);
            this.stat_status.Name = "stat_status";
            this.stat_status.Size = new System.Drawing.Size(119, 13);
            this.stat_status.TabIndex = 14;
            this.stat_status.Text = "enter transaction details";
            // 
            // AddTransactionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 276);
            this.Controls.Add(this.stat_status);
            this.Controls.Add(this.stat_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.desc_textbox);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.cat_combo);
            this.Controls.Add(this.cat_label);
            this.Controls.Add(this.type_groupbox);
            this.Controls.Add(this.acc_combo);
            this.Controls.Add(this.acc_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTransactionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction";
            this.type_groupbox.ResumeLayout(false);
            this.type_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acc_label;
        private System.Windows.Forms.ComboBox acc_combo;
        private System.Windows.Forms.GroupBox type_groupbox;
        private System.Windows.Forms.RadioButton deposit_radiobtn;
        private System.Windows.Forms.RadioButton pay_radiobtn;
        private System.Windows.Forms.Label cat_label;
        private System.Windows.Forms.ComboBox cat_combo;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.TextBox desc_textbox;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label stat_label;
        private System.Windows.Forms.Label stat_status;
    }
}