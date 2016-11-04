namespace Library
{
    partial class CreateLoanForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookLoanMember_label = new System.Windows.Forms.Label();
            this.bookLoan_label = new System.Windows.Forms.Label();
            this.loanTaker_comboBox = new System.Windows.Forms.ComboBox();
            this.availableBooks_comboBox = new System.Windows.Forms.ComboBox();
            this.cancelLoan_btn = new System.Windows.Forms.Button();
            this.createLoan_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // bookLoanMember_label
            // 
            this.bookLoanMember_label.AutoSize = true;
            this.bookLoanMember_label.Location = new System.Drawing.Point(18, 9);
            this.bookLoanMember_label.Name = "bookLoanMember_label";
            this.bookLoanMember_label.Size = new System.Drawing.Size(141, 17);
            this.bookLoanMember_label.TabIndex = 2;
            this.bookLoanMember_label.Text = "Loan taker (member)";
            // 
            // bookLoan_label
            // 
            this.bookLoan_label.AutoSize = true;
            this.bookLoan_label.Location = new System.Drawing.Point(18, 56);
            this.bookLoan_label.Name = "bookLoan_label";
            this.bookLoan_label.Size = new System.Drawing.Size(40, 17);
            this.bookLoan_label.TabIndex = 3;
            this.bookLoan_label.Text = "Book";
            // 
            // loanTaker_comboBox
            // 
            this.loanTaker_comboBox.FormattingEnabled = true;
            this.loanTaker_comboBox.Location = new System.Drawing.Point(19, 29);
            this.loanTaker_comboBox.Name = "loanTaker_comboBox";
            this.loanTaker_comboBox.Size = new System.Drawing.Size(364, 24);
            this.loanTaker_comboBox.TabIndex = 4;
            this.loanTaker_comboBox.SelectedIndexChanged += new System.EventHandler(this.loanTaker_comboBox_SelectedIndexChanged);
            // 
            // availableBooks_comboBox
            // 
            this.availableBooks_comboBox.FormattingEnabled = true;
            this.availableBooks_comboBox.Location = new System.Drawing.Point(19, 76);
            this.availableBooks_comboBox.Name = "availableBooks_comboBox";
            this.availableBooks_comboBox.Size = new System.Drawing.Size(364, 24);
            this.availableBooks_comboBox.TabIndex = 5;
            this.availableBooks_comboBox.SelectedIndexChanged += new System.EventHandler(this.availableBooks_comboBox_SelectedIndexChanged);
            // 
            // cancelLoan_btn
            // 
            this.cancelLoan_btn.Location = new System.Drawing.Point(19, 106);
            this.cancelLoan_btn.Name = "cancelLoan_btn";
            this.cancelLoan_btn.Size = new System.Drawing.Size(178, 41);
            this.cancelLoan_btn.TabIndex = 6;
            this.cancelLoan_btn.Text = "Cancel";
            this.cancelLoan_btn.UseVisualStyleBackColor = true;
            this.cancelLoan_btn.Click += new System.EventHandler(this.cancelLoan_btn_Click);
            // 
            // createLoan_btn
            // 
            this.createLoan_btn.Location = new System.Drawing.Point(203, 106);
            this.createLoan_btn.Name = "createLoan_btn";
            this.createLoan_btn.Size = new System.Drawing.Size(180, 42);
            this.createLoan_btn.TabIndex = 7;
            this.createLoan_btn.Text = "Create loan";
            this.createLoan_btn.UseVisualStyleBackColor = true;
            this.createLoan_btn.Click += new System.EventHandler(this.createLoan_btn_Click);
            // 
            // CreateLoanForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 162);
            this.Controls.Add(this.createLoan_btn);
            this.Controls.Add(this.cancelLoan_btn);
            this.Controls.Add(this.availableBooks_comboBox);
            this.Controls.Add(this.loanTaker_comboBox);
            this.Controls.Add(this.bookLoan_label);
            this.Controls.Add(this.bookLoanMember_label);
            this.Controls.Add(this.label1);
            this.Name = "CreateLoanForms";
            this.Text = "CreateLoanForms";
            this.Load += new System.EventHandler(this.CreateLoanForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookLoanMember_label;
        private System.Windows.Forms.Label bookLoan_label;
        private System.Windows.Forms.ComboBox loanTaker_comboBox;
        private System.Windows.Forms.ComboBox availableBooks_comboBox;
        private System.Windows.Forms.Button cancelLoan_btn;
        private System.Windows.Forms.Button createLoan_btn;
    }
}