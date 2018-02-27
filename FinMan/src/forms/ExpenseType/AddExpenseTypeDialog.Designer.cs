namespace FinMan.forms.ExpenseType
{
    partial class AddExpenseTypeDialog
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
            this.type_label = new System.Windows.Forms.Label();
            this.type_textbox = new System.Windows.Forms.TextBox();
            this.stat_label = new System.Windows.Forms.Label();
            this.stat_status = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(31, 25);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(30, 13);
            this.type_label.TabIndex = 0;
            this.type_label.Text = "type:";
            // 
            // type_textbox
            // 
            this.type_textbox.Location = new System.Drawing.Point(67, 22);
            this.type_textbox.Name = "type_textbox";
            this.type_textbox.Size = new System.Drawing.Size(100, 20);
            this.type_textbox.TabIndex = 1;
            // 
            // stat_label
            // 
            this.stat_label.AutoSize = true;
            this.stat_label.Location = new System.Drawing.Point(31, 55);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(38, 13);
            this.stat_label.TabIndex = 2;
            this.stat_label.Text = "status:";
            // 
            // stat_status
            // 
            this.stat_status.AutoSize = true;
            this.stat_status.Location = new System.Drawing.Point(73, 55);
            this.stat_status.Name = "stat_status";
            this.stat_status.Size = new System.Drawing.Size(126, 13);
            this.stat_status.TabIndex = 3;
            this.stat_status.Text = "enter expense type name";
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(168, 76);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(75, 23);
            this.done_btn.TabIndex = 4;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(87, 76);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // AddExpenseTypeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 111);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.stat_status);
            this.Controls.Add(this.stat_label);
            this.Controls.Add(this.type_textbox);
            this.Controls.Add(this.type_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddExpenseTypeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Expense Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.TextBox type_textbox;
        private System.Windows.Forms.Label stat_label;
        private System.Windows.Forms.Label stat_status;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}