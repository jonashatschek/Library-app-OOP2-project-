namespace Library
{
    partial class EditBookForm
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
            this.editBookDescription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.editBookAuthor_label = new System.Windows.Forms.Label();
            this.editDescription_label = new System.Windows.Forms.Label();
            this.editBookIsbn_label = new System.Windows.Forms.Label();
            this.editBookTitle_label = new System.Windows.Forms.Label();
            this.editBookIsbn_textbox = new System.Windows.Forms.TextBox();
            this.editBookTitle_textbox = new System.Windows.Forms.TextBox();
            this.saveEditedBook_btn = new System.Windows.Forms.Button();
            this.cancelEditedBook_btn = new System.Windows.Forms.Button();
            this.editAuthors_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // editBookDescription_richTextBox
            // 
            this.editBookDescription_richTextBox.Location = new System.Drawing.Point(15, 164);
            this.editBookDescription_richTextBox.Name = "editBookDescription_richTextBox";
            this.editBookDescription_richTextBox.Size = new System.Drawing.Size(314, 128);
            this.editBookDescription_richTextBox.TabIndex = 19;
            this.editBookDescription_richTextBox.Text = "";
            // 
            // editBookAuthor_label
            // 
            this.editBookAuthor_label.AutoSize = true;
            this.editBookAuthor_label.Location = new System.Drawing.Point(12, 99);
            this.editBookAuthor_label.Name = "editBookAuthor_label";
            this.editBookAuthor_label.Size = new System.Drawing.Size(50, 17);
            this.editBookAuthor_label.TabIndex = 18;
            this.editBookAuthor_label.Text = "Author";
            // 
            // editDescription_label
            // 
            this.editDescription_label.AutoSize = true;
            this.editDescription_label.Location = new System.Drawing.Point(12, 144);
            this.editDescription_label.Name = "editDescription_label";
            this.editDescription_label.Size = new System.Drawing.Size(79, 17);
            this.editDescription_label.TabIndex = 17;
            this.editDescription_label.Text = "Description";
            // 
            // editBookIsbn_label
            // 
            this.editBookIsbn_label.AutoSize = true;
            this.editBookIsbn_label.Location = new System.Drawing.Point(12, 54);
            this.editBookIsbn_label.Name = "editBookIsbn_label";
            this.editBookIsbn_label.Size = new System.Drawing.Size(39, 17);
            this.editBookIsbn_label.TabIndex = 16;
            this.editBookIsbn_label.Text = "ISBN";
            // 
            // editBookTitle_label
            // 
            this.editBookTitle_label.AutoSize = true;
            this.editBookTitle_label.Location = new System.Drawing.Point(12, 9);
            this.editBookTitle_label.Name = "editBookTitle_label";
            this.editBookTitle_label.Size = new System.Drawing.Size(35, 17);
            this.editBookTitle_label.TabIndex = 15;
            this.editBookTitle_label.Text = "Title";
            // 
            // editBookIsbn_textbox
            // 
            this.editBookIsbn_textbox.Location = new System.Drawing.Point(15, 74);
            this.editBookIsbn_textbox.Name = "editBookIsbn_textbox";
            this.editBookIsbn_textbox.Size = new System.Drawing.Size(314, 22);
            this.editBookIsbn_textbox.TabIndex = 13;
            // 
            // editBookTitle_textbox
            // 
            this.editBookTitle_textbox.Location = new System.Drawing.Point(15, 29);
            this.editBookTitle_textbox.Name = "editBookTitle_textbox";
            this.editBookTitle_textbox.Size = new System.Drawing.Size(314, 22);
            this.editBookTitle_textbox.TabIndex = 12;
            // 
            // saveEditedBook_btn
            // 
            this.saveEditedBook_btn.Location = new System.Drawing.Point(15, 315);
            this.saveEditedBook_btn.Name = "saveEditedBook_btn";
            this.saveEditedBook_btn.Size = new System.Drawing.Size(148, 44);
            this.saveEditedBook_btn.TabIndex = 20;
            this.saveEditedBook_btn.Text = "Save";
            this.saveEditedBook_btn.UseVisualStyleBackColor = true;
            // 
            // cancelEditedBook_btn
            // 
            this.cancelEditedBook_btn.Location = new System.Drawing.Point(180, 315);
            this.cancelEditedBook_btn.Name = "cancelEditedBook_btn";
            this.cancelEditedBook_btn.Size = new System.Drawing.Size(149, 44);
            this.cancelEditedBook_btn.TabIndex = 21;
            this.cancelEditedBook_btn.Text = "Cancel";
            this.cancelEditedBook_btn.UseVisualStyleBackColor = true;
            // 
            // editAuthors_comboBox
            // 
            this.editAuthors_comboBox.FormattingEnabled = true;
            this.editAuthors_comboBox.Location = new System.Drawing.Point(15, 119);
            this.editAuthors_comboBox.Name = "editAuthors_comboBox";
            this.editAuthors_comboBox.Size = new System.Drawing.Size(314, 24);
            this.editAuthors_comboBox.TabIndex = 22;
            this.editAuthors_comboBox.SelectedIndexChanged += new System.EventHandler(this.editAuthors_comboBox_SelectedIndexChanged);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 371);
            this.Controls.Add(this.editAuthors_comboBox);
            this.Controls.Add(this.cancelEditedBook_btn);
            this.Controls.Add(this.saveEditedBook_btn);
            this.Controls.Add(this.editBookDescription_richTextBox);
            this.Controls.Add(this.editBookAuthor_label);
            this.Controls.Add(this.editDescription_label);
            this.Controls.Add(this.editBookIsbn_label);
            this.Controls.Add(this.editBookTitle_label);
            this.Controls.Add(this.editBookIsbn_textbox);
            this.Controls.Add(this.editBookTitle_textbox);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox editBookDescription_richTextBox;
        private System.Windows.Forms.Label editBookAuthor_label;
        private System.Windows.Forms.Label editDescription_label;
        private System.Windows.Forms.Label editBookIsbn_label;
        private System.Windows.Forms.Label editBookTitle_label;
        private System.Windows.Forms.TextBox editBookIsbn_textbox;
        private System.Windows.Forms.TextBox editBookTitle_textbox;
        private System.Windows.Forms.Button saveEditedBook_btn;
        private System.Windows.Forms.Button cancelEditedBook_btn;
        private System.Windows.Forms.ComboBox editAuthors_comboBox;
    }
}