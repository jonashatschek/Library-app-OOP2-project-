namespace Library
{
    partial class AddNewMemberForm
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
            this.AddNewMember_btn = new System.Windows.Forms.Button();
            this.addNewMemberCancel_btn = new System.Windows.Forms.Button();
            this.addNewMemberName_textbox = new System.Windows.Forms.TextBox();
            this.addNewMember_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewMemberId_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddNewMember_btn
            // 
            this.AddNewMember_btn.Location = new System.Drawing.Point(140, 133);
            this.AddNewMember_btn.Name = "AddNewMember_btn";
            this.AddNewMember_btn.Size = new System.Drawing.Size(124, 55);
            this.AddNewMember_btn.TabIndex = 0;
            this.AddNewMember_btn.Text = "Add new member";
            this.AddNewMember_btn.UseVisualStyleBackColor = true;
            this.AddNewMember_btn.Click += new System.EventHandler(this.AddNewMember_btn_Click);
            // 
            // addNewMemberCancel_btn
            // 
            this.addNewMemberCancel_btn.Location = new System.Drawing.Point(12, 133);
            this.addNewMemberCancel_btn.Name = "addNewMemberCancel_btn";
            this.addNewMemberCancel_btn.Size = new System.Drawing.Size(122, 55);
            this.addNewMemberCancel_btn.TabIndex = 1;
            this.addNewMemberCancel_btn.Text = "Cancel";
            this.addNewMemberCancel_btn.UseVisualStyleBackColor = true;
            this.addNewMemberCancel_btn.Click += new System.EventHandler(this.addNewMemberCancel_btn_Click);
            // 
            // addNewMemberName_textbox
            // 
            this.addNewMemberName_textbox.Location = new System.Drawing.Point(12, 29);
            this.addNewMemberName_textbox.Name = "addNewMemberName_textbox";
            this.addNewMemberName_textbox.Size = new System.Drawing.Size(252, 22);
            this.addNewMemberName_textbox.TabIndex = 2;
            // 
            // addNewMember_label
            // 
            this.addNewMember_label.AutoSize = true;
            this.addNewMember_label.Location = new System.Drawing.Point(9, 9);
            this.addNewMember_label.Name = "addNewMember_label";
            this.addNewMember_label.Size = new System.Drawing.Size(45, 17);
            this.addNewMember_label.TabIndex = 3;
            this.addNewMember_label.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID number";
            // 
            // addNewMemberId_textbox
            // 
            this.addNewMemberId_textbox.Location = new System.Drawing.Point(12, 84);
            this.addNewMemberId_textbox.Name = "addNewMemberId_textbox";
            this.addNewMemberId_textbox.Size = new System.Drawing.Size(252, 22);
            this.addNewMemberId_textbox.TabIndex = 5;
            // 
            // AddNewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 221);
            this.Controls.Add(this.addNewMemberId_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewMember_label);
            this.Controls.Add(this.addNewMemberName_textbox);
            this.Controls.Add(this.addNewMemberCancel_btn);
            this.Controls.Add(this.AddNewMember_btn);
            this.Name = "AddNewMemberForm";
            this.Text = "AddNewMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewMember_btn;
        private System.Windows.Forms.Button addNewMemberCancel_btn;
        private System.Windows.Forms.TextBox addNewMemberName_textbox;
        private System.Windows.Forms.Label addNewMember_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addNewMemberId_textbox;
    }
}