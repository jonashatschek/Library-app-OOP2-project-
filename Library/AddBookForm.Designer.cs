namespace Library
{
    partial class AddBookForm
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
            this.booksAdd_btn = new System.Windows.Forms.Button();
            this.addBookTitle_textbox = new System.Windows.Forms.TextBox();
            this.addBookIsbn_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBookIsbn_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.addBookAuthor_label = new System.Windows.Forms.Label();
            this.addBookDescription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.addNewBookAllAuthors_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // booksAdd_btn
            // 
            this.booksAdd_btn.Location = new System.Drawing.Point(194, 328);
            this.booksAdd_btn.Name = "booksAdd_btn";
            this.booksAdd_btn.Size = new System.Drawing.Size(136, 42);
            this.booksAdd_btn.TabIndex = 2;
            this.booksAdd_btn.Text = "Add book";
            this.booksAdd_btn.UseVisualStyleBackColor = true;
            this.booksAdd_btn.Click += new System.EventHandler(this.booksAdd_btn_Click);
            // 
            // addBookTitle_textbox
            // 
            this.addBookTitle_textbox.Location = new System.Drawing.Point(16, 39);
            this.addBookTitle_textbox.Name = "addBookTitle_textbox";
            this.addBookTitle_textbox.Size = new System.Drawing.Size(314, 22);
            this.addBookTitle_textbox.TabIndex = 3;
            // 
            // addBookIsbn_textbox
            // 
            this.addBookIsbn_textbox.Location = new System.Drawing.Point(16, 84);
            this.addBookIsbn_textbox.Name = "addBookIsbn_textbox";
            this.addBookIsbn_textbox.Size = new System.Drawing.Size(314, 22);
            this.addBookIsbn_textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // addBookIsbn_label
            // 
            this.addBookIsbn_label.AutoSize = true;
            this.addBookIsbn_label.Location = new System.Drawing.Point(13, 64);
            this.addBookIsbn_label.Name = "addBookIsbn_label";
            this.addBookIsbn_label.Size = new System.Drawing.Size(39, 17);
            this.addBookIsbn_label.TabIndex = 8;
            this.addBookIsbn_label.Text = "ISBN";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(13, 154);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(79, 17);
            this.description_label.TabIndex = 9;
            this.description_label.Text = "Description";
            // 
            // addBookAuthor_label
            // 
            this.addBookAuthor_label.AutoSize = true;
            this.addBookAuthor_label.Location = new System.Drawing.Point(13, 109);
            this.addBookAuthor_label.Name = "addBookAuthor_label";
            this.addBookAuthor_label.Size = new System.Drawing.Size(50, 17);
            this.addBookAuthor_label.TabIndex = 10;
            this.addBookAuthor_label.Text = "Author";
            // 
            // addBookDescription_richTextBox
            // 
            this.addBookDescription_richTextBox.Location = new System.Drawing.Point(16, 174);
            this.addBookDescription_richTextBox.Name = "addBookDescription_richTextBox";
            this.addBookDescription_richTextBox.Size = new System.Drawing.Size(314, 128);
            this.addBookDescription_richTextBox.TabIndex = 11;
            this.addBookDescription_richTextBox.Text = "";
            // 
            // addNewBookAllAuthors_comboBox
            // 
            this.addNewBookAllAuthors_comboBox.FormattingEnabled = true;
            this.addNewBookAllAuthors_comboBox.Location = new System.Drawing.Point(16, 130);
            this.addNewBookAllAuthors_comboBox.Name = "addNewBookAllAuthors_comboBox";
            this.addNewBookAllAuthors_comboBox.Size = new System.Drawing.Size(314, 24);
            this.addNewBookAllAuthors_comboBox.TabIndex = 12;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 394);
            this.Controls.Add(this.addNewBookAllAuthors_comboBox);
            this.Controls.Add(this.addBookDescription_richTextBox);
            this.Controls.Add(this.addBookAuthor_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.addBookIsbn_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBookIsbn_textbox);
            this.Controls.Add(this.addBookTitle_textbox);
            this.Controls.Add(this.booksAdd_btn);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button booksAdd_btn;
        private System.Windows.Forms.TextBox addBookTitle_textbox;
        private System.Windows.Forms.TextBox addBookIsbn_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addBookIsbn_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label addBookAuthor_label;
        private System.Windows.Forms.RichTextBox addBookDescription_richTextBox;
        private System.Windows.Forms.ComboBox addNewBookAllAuthors_comboBox;
    }
}