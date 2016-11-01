namespace Library
{
    partial class AddNewBookCopyForm
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
            this.BookBookCopy_label = new System.Windows.Forms.Label();
            this.AddBookCopy_comboBox = new System.Windows.Forms.ComboBox();
            this.addNewBookCopy_btn = new System.Windows.Forms.Button();
            this.removeBookCopy_btn = new System.Windows.Forms.Button();
            this.seeBookCopiesByBook_listBox = new System.Windows.Forms.ListBox();
            this.doneNewBookCopy_btn = new System.Windows.Forms.Button();
            this.currentBookCopies_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookBookCopy_label
            // 
            this.BookBookCopy_label.AutoSize = true;
            this.BookBookCopy_label.Location = new System.Drawing.Point(13, 13);
            this.BookBookCopy_label.Name = "BookBookCopy_label";
            this.BookBookCopy_label.Size = new System.Drawing.Size(40, 17);
            this.BookBookCopy_label.TabIndex = 0;
            this.BookBookCopy_label.Text = "Book";
            // 
            // AddBookCopy_comboBox
            // 
            this.AddBookCopy_comboBox.FormattingEnabled = true;
            this.AddBookCopy_comboBox.Location = new System.Drawing.Point(15, 35);
            this.AddBookCopy_comboBox.Name = "AddBookCopy_comboBox";
            this.AddBookCopy_comboBox.Size = new System.Drawing.Size(231, 24);
            this.AddBookCopy_comboBox.TabIndex = 1;
            this.AddBookCopy_comboBox.SelectedIndexChanged += new System.EventHandler(this.AddBookCopy_comboBox_SelectedIndexChanged);
            // 
            // addNewBookCopy_btn
            // 
            this.addNewBookCopy_btn.Location = new System.Drawing.Point(253, 35);
            this.addNewBookCopy_btn.Name = "addNewBookCopy_btn";
            this.addNewBookCopy_btn.Size = new System.Drawing.Size(45, 24);
            this.addNewBookCopy_btn.TabIndex = 2;
            this.addNewBookCopy_btn.Text = "+";
            this.addNewBookCopy_btn.UseVisualStyleBackColor = true;
            this.addNewBookCopy_btn.Click += new System.EventHandler(this.addNewBookCopy_btn_Click);
            // 
            // removeBookCopy_btn
            // 
            this.removeBookCopy_btn.Location = new System.Drawing.Point(304, 34);
            this.removeBookCopy_btn.Name = "removeBookCopy_btn";
            this.removeBookCopy_btn.Size = new System.Drawing.Size(48, 25);
            this.removeBookCopy_btn.TabIndex = 3;
            this.removeBookCopy_btn.Text = "-";
            this.removeBookCopy_btn.UseVisualStyleBackColor = true;
            this.removeBookCopy_btn.Click += new System.EventHandler(this.removeBookCopy_btn_Click);
            // 
            // seeBookCopiesByBook_listBox
            // 
            this.seeBookCopiesByBook_listBox.FormattingEnabled = true;
            this.seeBookCopiesByBook_listBox.ItemHeight = 16;
            this.seeBookCopiesByBook_listBox.Location = new System.Drawing.Point(12, 82);
            this.seeBookCopiesByBook_listBox.Name = "seeBookCopiesByBook_listBox";
            this.seeBookCopiesByBook_listBox.Size = new System.Drawing.Size(341, 116);
            this.seeBookCopiesByBook_listBox.TabIndex = 4;
            this.seeBookCopiesByBook_listBox.SelectedIndexChanged += new System.EventHandler(this.seeBookCopiesByBook_listBox_SelectedIndexChanged);
            // 
            // doneNewBookCopy_btn
            // 
            this.doneNewBookCopy_btn.Location = new System.Drawing.Point(12, 204);
            this.doneNewBookCopy_btn.Name = "doneNewBookCopy_btn";
            this.doneNewBookCopy_btn.Size = new System.Drawing.Size(341, 56);
            this.doneNewBookCopy_btn.TabIndex = 5;
            this.doneNewBookCopy_btn.Text = "Done";
            this.doneNewBookCopy_btn.UseVisualStyleBackColor = true;
            // 
            // currentBookCopies_label
            // 
            this.currentBookCopies_label.AutoSize = true;
            this.currentBookCopies_label.Location = new System.Drawing.Point(13, 62);
            this.currentBookCopies_label.Name = "currentBookCopies_label";
            this.currentBookCopies_label.Size = new System.Drawing.Size(135, 17);
            this.currentBookCopies_label.TabIndex = 6;
            this.currentBookCopies_label.Text = "Current book copies";
            // 
            // AddNewBookCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 265);
            this.Controls.Add(this.currentBookCopies_label);
            this.Controls.Add(this.doneNewBookCopy_btn);
            this.Controls.Add(this.seeBookCopiesByBook_listBox);
            this.Controls.Add(this.removeBookCopy_btn);
            this.Controls.Add(this.addNewBookCopy_btn);
            this.Controls.Add(this.AddBookCopy_comboBox);
            this.Controls.Add(this.BookBookCopy_label);
            this.Name = "AddNewBookCopyForm";
            this.Text = "AddNewBookCopyForm";
            this.Load += new System.EventHandler(this.AddNewBookCopyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookBookCopy_label;
        private System.Windows.Forms.ComboBox AddBookCopy_comboBox;
        private System.Windows.Forms.Button addNewBookCopy_btn;
        private System.Windows.Forms.Button removeBookCopy_btn;
        private System.Windows.Forms.ListBox seeBookCopiesByBook_listBox;
        private System.Windows.Forms.Button doneNewBookCopy_btn;
        private System.Windows.Forms.Label currentBookCopies_label;
    }
}