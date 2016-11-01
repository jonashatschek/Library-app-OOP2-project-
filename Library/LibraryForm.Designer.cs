﻿namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.books_listbox = new System.Windows.Forms.ListBox();
            this.tabPageForm = new System.Windows.Forms.TabControl();
            this.books_tabPage = new System.Windows.Forms.TabPage();
            this.createNewLoan_btn = new System.Windows.Forms.Button();
            this.removeBook_btn = new System.Windows.Forms.Button();
            this.editBook_btn = new System.Windows.Forms.Button();
            this.booksAdd_btn = new System.Windows.Forms.Button();
            this.authors_tabPage = new System.Windows.Forms.TabPage();
            this.filterByAuthor_label = new System.Windows.Forms.Label();
            this.filterListByAuthor_comboBox = new System.Windows.Forms.ComboBox();
            this.addNewAuthor_btn = new System.Windows.Forms.Button();
            this.authors_listbox = new System.Windows.Forms.ListBox();
            this.loans_tabPage = new System.Windows.Forms.TabPage();
            this.loans_listbox = new System.Windows.Forms.ListBox();
            this.members_tabPage = new System.Windows.Forms.TabPage();
            this.addNewMemberPopup_btn = new System.Windows.Forms.Button();
            this.members_listbox = new System.Windows.Forms.ListBox();
            this.bookCopies_tabPage = new System.Windows.Forms.TabPage();
            this.addNewBookCopy_btn = new System.Windows.Forms.Button();
            this.bookCopies_listbox = new System.Windows.Forms.ListBox();
            this.tabPageForm.SuspendLayout();
            this.books_tabPage.SuspendLayout();
            this.authors_tabPage.SuspendLayout();
            this.loans_tabPage.SuspendLayout();
            this.members_tabPage.SuspendLayout();
            this.bookCopies_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // books_listbox
            // 
            this.books_listbox.FormattingEnabled = true;
            this.books_listbox.ItemHeight = 16;
            this.books_listbox.Location = new System.Drawing.Point(7, 7);
            this.books_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.books_listbox.Name = "books_listbox";
            this.books_listbox.Size = new System.Drawing.Size(275, 388);
            this.books_listbox.TabIndex = 0;
            this.books_listbox.SelectedIndexChanged += new System.EventHandler(this.books_listbox_SelectedIndexChanged);
            // 
            // tabPageForm
            // 
            this.tabPageForm.Controls.Add(this.books_tabPage);
            this.tabPageForm.Controls.Add(this.authors_tabPage);
            this.tabPageForm.Controls.Add(this.loans_tabPage);
            this.tabPageForm.Controls.Add(this.members_tabPage);
            this.tabPageForm.Controls.Add(this.bookCopies_tabPage);
            this.tabPageForm.Location = new System.Drawing.Point(12, 12);
            this.tabPageForm.Name = "tabPageForm";
            this.tabPageForm.Padding = new System.Drawing.Point(50, 20);
            this.tabPageForm.SelectedIndex = 0;
            this.tabPageForm.Size = new System.Drawing.Size(979, 481);
            this.tabPageForm.TabIndex = 1;
            // 
            // books_tabPage
            // 
            this.books_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.books_tabPage.Controls.Add(this.filterByAuthor_label);
            this.books_tabPage.Controls.Add(this.createNewLoan_btn);
            this.books_tabPage.Controls.Add(this.filterListByAuthor_comboBox);
            this.books_tabPage.Controls.Add(this.removeBook_btn);
            this.books_tabPage.Controls.Add(this.editBook_btn);
            this.books_tabPage.Controls.Add(this.booksAdd_btn);
            this.books_tabPage.Controls.Add(this.books_listbox);
            this.books_tabPage.Location = new System.Drawing.Point(4, 59);
            this.books_tabPage.Name = "books_tabPage";
            this.books_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.books_tabPage.Size = new System.Drawing.Size(971, 418);
            this.books_tabPage.TabIndex = 0;
            this.books_tabPage.Text = "Books";
            // 
            // createNewLoan_btn
            // 
            this.createNewLoan_btn.Location = new System.Drawing.Point(447, 7);
            this.createNewLoan_btn.Name = "createNewLoan_btn";
            this.createNewLoan_btn.Size = new System.Drawing.Size(166, 46);
            this.createNewLoan_btn.TabIndex = 4;
            this.createNewLoan_btn.Text = "Create loan";
            this.createNewLoan_btn.UseVisualStyleBackColor = true;
            this.createNewLoan_btn.Click += new System.EventHandler(this.createNewLoan_btn_Click);
            // 
            // removeBook_btn
            // 
            this.removeBook_btn.Location = new System.Drawing.Point(289, 92);
            this.removeBook_btn.Name = "removeBook_btn";
            this.removeBook_btn.Size = new System.Drawing.Size(108, 40);
            this.removeBook_btn.TabIndex = 3;
            this.removeBook_btn.Text = "Remove book";
            this.removeBook_btn.UseVisualStyleBackColor = true;
            this.removeBook_btn.Click += new System.EventHandler(this.removeBook_btn_Click);
            // 
            // editBook_btn
            // 
            this.editBook_btn.Location = new System.Drawing.Point(289, 49);
            this.editBook_btn.Name = "editBook_btn";
            this.editBook_btn.Size = new System.Drawing.Size(108, 37);
            this.editBook_btn.TabIndex = 2;
            this.editBook_btn.Text = "Edit book";
            this.editBook_btn.UseVisualStyleBackColor = true;
            this.editBook_btn.Click += new System.EventHandler(this.editBook_btn_Click);
            // 
            // booksAdd_btn
            // 
            this.booksAdd_btn.Location = new System.Drawing.Point(289, 7);
            this.booksAdd_btn.Name = "booksAdd_btn";
            this.booksAdd_btn.Size = new System.Drawing.Size(108, 36);
            this.booksAdd_btn.TabIndex = 1;
            this.booksAdd_btn.Text = "Add new book";
            this.booksAdd_btn.UseVisualStyleBackColor = true;
            this.booksAdd_btn.Click += new System.EventHandler(this.booksAdd_btn_Click);
            // 
            // authors_tabPage
            // 
            this.authors_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.authors_tabPage.Controls.Add(this.addNewAuthor_btn);
            this.authors_tabPage.Controls.Add(this.authors_listbox);
            this.authors_tabPage.Location = new System.Drawing.Point(4, 59);
            this.authors_tabPage.Name = "authors_tabPage";
            this.authors_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.authors_tabPage.Size = new System.Drawing.Size(971, 418);
            this.authors_tabPage.TabIndex = 1;
            this.authors_tabPage.Text = "Authors";
            // 
            // filterByAuthor_label
            // 
            this.filterByAuthor_label.AutoSize = true;
            this.filterByAuthor_label.Location = new System.Drawing.Point(764, 3);
            this.filterByAuthor_label.Name = "filterByAuthor_label";
            this.filterByAuthor_label.Size = new System.Drawing.Size(124, 17);
            this.filterByAuthor_label.TabIndex = 3;
            this.filterByAuthor_label.Text = "Filter list by author";
            // 
            // filterListByAuthor_comboBox
            // 
            this.filterListByAuthor_comboBox.FormattingEnabled = true;
            this.filterListByAuthor_comboBox.Location = new System.Drawing.Point(767, 29);
            this.filterListByAuthor_comboBox.Name = "filterListByAuthor_comboBox";
            this.filterListByAuthor_comboBox.Size = new System.Drawing.Size(198, 24);
            this.filterListByAuthor_comboBox.TabIndex = 2;
            this.filterListByAuthor_comboBox.SelectedIndexChanged += new System.EventHandler(this.filterListByAuthor_comboBox_SelectedIndexChanged);
            // 
            // addNewAuthor_btn
            // 
            this.addNewAuthor_btn.Location = new System.Drawing.Point(311, 348);
            this.addNewAuthor_btn.Name = "addNewAuthor_btn";
            this.addNewAuthor_btn.Size = new System.Drawing.Size(148, 45);
            this.addNewAuthor_btn.TabIndex = 1;
            this.addNewAuthor_btn.Text = "Add new author";
            this.addNewAuthor_btn.UseVisualStyleBackColor = true;
            this.addNewAuthor_btn.Click += new System.EventHandler(this.addNewAuthor_btn_Click);
            // 
            // authors_listbox
            // 
            this.authors_listbox.FormattingEnabled = true;
            this.authors_listbox.ItemHeight = 16;
            this.authors_listbox.Location = new System.Drawing.Point(6, 6);
            this.authors_listbox.Name = "authors_listbox";
            this.authors_listbox.Size = new System.Drawing.Size(277, 388);
            this.authors_listbox.TabIndex = 0;
            // 
            // loans_tabPage
            // 
            this.loans_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.loans_tabPage.Controls.Add(this.loans_listbox);
            this.loans_tabPage.Location = new System.Drawing.Point(4, 59);
            this.loans_tabPage.Name = "loans_tabPage";
            this.loans_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loans_tabPage.Size = new System.Drawing.Size(971, 418);
            this.loans_tabPage.TabIndex = 2;
            this.loans_tabPage.Text = "Loans";
            // 
            // loans_listbox
            // 
            this.loans_listbox.FormattingEnabled = true;
            this.loans_listbox.ItemHeight = 16;
            this.loans_listbox.Location = new System.Drawing.Point(6, 6);
            this.loans_listbox.Name = "loans_listbox";
            this.loans_listbox.Size = new System.Drawing.Size(274, 388);
            this.loans_listbox.TabIndex = 0;
            // 
            // members_tabPage
            // 
            this.members_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.members_tabPage.Controls.Add(this.addNewMemberPopup_btn);
            this.members_tabPage.Controls.Add(this.members_listbox);
            this.members_tabPage.Location = new System.Drawing.Point(4, 59);
            this.members_tabPage.Name = "members_tabPage";
            this.members_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.members_tabPage.Size = new System.Drawing.Size(971, 418);
            this.members_tabPage.TabIndex = 3;
            this.members_tabPage.Text = "Members";
            // 
            // addNewMemberPopup_btn
            // 
            this.addNewMemberPopup_btn.Location = new System.Drawing.Point(285, 352);
            this.addNewMemberPopup_btn.Name = "addNewMemberPopup_btn";
            this.addNewMemberPopup_btn.Size = new System.Drawing.Size(159, 42);
            this.addNewMemberPopup_btn.TabIndex = 1;
            this.addNewMemberPopup_btn.Text = "Add new member";
            this.addNewMemberPopup_btn.UseVisualStyleBackColor = true;
            this.addNewMemberPopup_btn.Click += new System.EventHandler(this.addNewMemberPopup_btn_Click);
            // 
            // members_listbox
            // 
            this.members_listbox.FormattingEnabled = true;
            this.members_listbox.ItemHeight = 16;
            this.members_listbox.Location = new System.Drawing.Point(7, 7);
            this.members_listbox.Name = "members_listbox";
            this.members_listbox.Size = new System.Drawing.Size(271, 388);
            this.members_listbox.TabIndex = 0;
            // 
            // bookCopies_tabPage
            // 
            this.bookCopies_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.bookCopies_tabPage.Controls.Add(this.addNewBookCopy_btn);
            this.bookCopies_tabPage.Controls.Add(this.bookCopies_listbox);
            this.bookCopies_tabPage.Location = new System.Drawing.Point(4, 59);
            this.bookCopies_tabPage.Name = "bookCopies_tabPage";
            this.bookCopies_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookCopies_tabPage.Size = new System.Drawing.Size(971, 418);
            this.bookCopies_tabPage.TabIndex = 4;
            this.bookCopies_tabPage.Text = "Book copies";
            // 
            // addNewBookCopy_btn
            // 
            this.addNewBookCopy_btn.Location = new System.Drawing.Point(284, 352);
            this.addNewBookCopy_btn.Name = "addNewBookCopy_btn";
            this.addNewBookCopy_btn.Size = new System.Drawing.Size(132, 42);
            this.addNewBookCopy_btn.TabIndex = 1;
            this.addNewBookCopy_btn.Text = "Add new copy";
            this.addNewBookCopy_btn.UseVisualStyleBackColor = true;
            this.addNewBookCopy_btn.Click += new System.EventHandler(this.addNewBookCopy_btn_Click);
            // 
            // bookCopies_listbox
            // 
            this.bookCopies_listbox.FormattingEnabled = true;
            this.bookCopies_listbox.ItemHeight = 16;
            this.bookCopies_listbox.Location = new System.Drawing.Point(7, 7);
            this.bookCopies_listbox.Name = "bookCopies_listbox";
            this.bookCopies_listbox.Size = new System.Drawing.Size(270, 388);
            this.bookCopies_listbox.TabIndex = 0;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 505);
            this.Controls.Add(this.tabPageForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.tabPageForm.ResumeLayout(false);
            this.books_tabPage.ResumeLayout(false);
            this.books_tabPage.PerformLayout();
            this.authors_tabPage.ResumeLayout(false);
            this.loans_tabPage.ResumeLayout(false);
            this.members_tabPage.ResumeLayout(false);
            this.bookCopies_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox books_listbox;
        private System.Windows.Forms.TabControl tabPageForm;
        private System.Windows.Forms.TabPage books_tabPage;
        private System.Windows.Forms.TabPage authors_tabPage;
        private System.Windows.Forms.TabPage loans_tabPage;
        private System.Windows.Forms.TabPage members_tabPage;
        private System.Windows.Forms.TabPage bookCopies_tabPage;
        private System.Windows.Forms.Button removeBook_btn;
        private System.Windows.Forms.Button editBook_btn;
        private System.Windows.Forms.Button booksAdd_btn;
        private System.Windows.Forms.ListBox authors_listbox;
        private System.Windows.Forms.ListBox loans_listbox;
        private System.Windows.Forms.ListBox members_listbox;
        private System.Windows.Forms.ListBox bookCopies_listbox;
        private System.Windows.Forms.Button addNewAuthor_btn;
        private System.Windows.Forms.Button addNewMemberPopup_btn;
        private System.Windows.Forms.Button createNewLoan_btn;
        private System.Windows.Forms.Button addNewBookCopy_btn;
        private System.Windows.Forms.Label filterByAuthor_label;
        private System.Windows.Forms.ComboBox filterListByAuthor_comboBox;
    }
}

