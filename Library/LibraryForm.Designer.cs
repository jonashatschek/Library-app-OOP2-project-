namespace Library {
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
            this.booksInformation_groupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayDescriptionBooks_textBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayTitleBooks_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayAuthorBooks_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.displayISBNBooks_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.displayNumberOfAvailableCopies_textBox = new System.Windows.Forms.TextBox();
            this.filterByAuthor_label = new System.Windows.Forms.Label();
            this.createNewLoan_btn = new System.Windows.Forms.Button();
            this.filterListByAuthor_comboBox = new System.Windows.Forms.ComboBox();
            this.removeBook_btn = new System.Windows.Forms.Button();
            this.editBook_btn = new System.Windows.Forms.Button();
            this.booksAdd_btn = new System.Windows.Forms.Button();
            this.authors_tabPage = new System.Windows.Forms.TabPage();
            this.authorsListView = new System.Windows.Forms.ListView();
            this.bookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvailableCompies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.addNewAuthor_btn = new System.Windows.Forms.Button();
            this.authors_listbox = new System.Windows.Forms.ListBox();
            this.loans_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LoanStatus_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MemberHavingLoan_textBox = new System.Windows.Forms.TextBox();
            this.BookCopyTitleLoan_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnDateLoan_texrBox = new System.Windows.Forms.TextBox();
            this.AuthorNameLoan_textBox = new System.Windows.Forms.TextBox();
            this.ReturnSelectedBookCopy_btn = new System.Windows.Forms.Button();
            this.TotalLoanHistory_radioBtn = new System.Windows.Forms.RadioButton();
            this.ShowAllReturnedBooks_radioBtn = new System.Windows.Forms.RadioButton();
            this.ShowAllCurrentlyLateBooks_radioBtn = new System.Windows.Forms.RadioButton();
            this.ShowAllCurrentLoans_radioBtn = new System.Windows.Forms.RadioButton();
            this.loans_listbox = new System.Windows.Forms.ListBox();
            this.members_tabPage = new System.Windows.Forms.TabPage();
            this.MemberListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DisplayMemberDept_listBox = new System.Windows.Forms.TextBox();
            this.DisplayMemberPersonalId_textBox = new System.Windows.Forms.TextBox();
            this.DisplayMemberNameMemberPage_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addNewMemberPopup_btn = new System.Windows.Forms.Button();
            this.members_listbox = new System.Windows.Forms.ListBox();
            this.bookCopies_tabPage = new System.Windows.Forms.TabPage();
            this.addNewBookCopy_btn = new System.Windows.Forms.Button();
            this.bookCopies_listbox = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.AuthorNameFromBookCopy_textbox = new System.Windows.Forms.TextBox();
            this.AmountOfCopiesInStore_textBox = new System.Windows.Forms.TextBox();
            this.AmountOfCopiesOnLoan_textbox = new System.Windows.Forms.TextBox();
            this.TotalNumberOfCopies_textbox = new System.Windows.Forms.TextBox();
            this.tabPageForm.SuspendLayout();
            this.books_tabPage.SuspendLayout();
            this.booksInformation_groupBox.SuspendLayout();
            this.authors_tabPage.SuspendLayout();
            this.loans_tabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.books_listbox.Size = new System.Drawing.Size(342, 404);
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
            this.tabPageForm.Size = new System.Drawing.Size(1028, 481);
            this.tabPageForm.TabIndex = 1;
            // 
            // books_tabPage
            // 
            this.books_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.books_tabPage.Controls.Add(this.booksInformation_groupBox);
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
            this.books_tabPage.Size = new System.Drawing.Size(1020, 418);
            this.books_tabPage.TabIndex = 0;
            this.books_tabPage.Text = "Books";
            this.books_tabPage.Click += new System.EventHandler(this.books_tabPage_Click);
            // 
            // booksInformation_groupBox
            // 
            this.booksInformation_groupBox.Controls.Add(this.label5);
            this.booksInformation_groupBox.Controls.Add(this.displayDescriptionBooks_textBox);
            this.booksInformation_groupBox.Controls.Add(this.label1);
            this.booksInformation_groupBox.Controls.Add(this.displayTitleBooks_textBox);
            this.booksInformation_groupBox.Controls.Add(this.label2);
            this.booksInformation_groupBox.Controls.Add(this.displayAuthorBooks_textBox);
            this.booksInformation_groupBox.Controls.Add(this.label3);
            this.booksInformation_groupBox.Controls.Add(this.displayISBNBooks_textBox);
            this.booksInformation_groupBox.Controls.Add(this.label4);
            this.booksInformation_groupBox.Controls.Add(this.displayNumberOfAvailableCopies_textBox);
            this.booksInformation_groupBox.Location = new System.Drawing.Point(591, 140);
            this.booksInformation_groupBox.Name = "booksInformation_groupBox";
            this.booksInformation_groupBox.Size = new System.Drawing.Size(423, 271);
            this.booksInformation_groupBox.TabIndex = 5;
            this.booksInformation_groupBox.TabStop = false;
            this.booksInformation_groupBox.Text = "Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description";
            // 
            // displayDescriptionBooks_textBox
            // 
            this.displayDescriptionBooks_textBox.Location = new System.Drawing.Point(9, 166);
            this.displayDescriptionBooks_textBox.Name = "displayDescriptionBooks_textBox";
            this.displayDescriptionBooks_textBox.ReadOnly = true;
            this.displayDescriptionBooks_textBox.Size = new System.Drawing.Size(399, 88);
            this.displayDescriptionBooks_textBox.TabIndex = 19;
            this.displayDescriptionBooks_textBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayTitleBooks_textBox
            // 
            this.displayTitleBooks_textBox.Location = new System.Drawing.Point(6, 54);
            this.displayTitleBooks_textBox.Name = "displayTitleBooks_textBox";
            this.displayTitleBooks_textBox.ReadOnly = true;
            this.displayTitleBooks_textBox.Size = new System.Drawing.Size(189, 22);
            this.displayTitleBooks_textBox.TabIndex = 9;
            this.displayTitleBooks_textBox.TextChanged += new System.EventHandler(this.displayTitleBooks_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Author";
            // 
            // displayAuthorBooks_textBox
            // 
            this.displayAuthorBooks_textBox.Location = new System.Drawing.Point(232, 54);
            this.displayAuthorBooks_textBox.Name = "displayAuthorBooks_textBox";
            this.displayAuthorBooks_textBox.ReadOnly = true;
            this.displayAuthorBooks_textBox.Size = new System.Drawing.Size(176, 22);
            this.displayAuthorBooks_textBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "ISBN";
            // 
            // displayISBNBooks_textBox
            // 
            this.displayISBNBooks_textBox.Location = new System.Drawing.Point(9, 109);
            this.displayISBNBooks_textBox.Name = "displayISBNBooks_textBox";
            this.displayISBNBooks_textBox.ReadOnly = true;
            this.displayISBNBooks_textBox.Size = new System.Drawing.Size(140, 22);
            this.displayISBNBooks_textBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number of available copies";
            // 
            // displayNumberOfAvailableCopies_textBox
            // 
            this.displayNumberOfAvailableCopies_textBox.Location = new System.Drawing.Point(232, 109);
            this.displayNumberOfAvailableCopies_textBox.Name = "displayNumberOfAvailableCopies_textBox";
            this.displayNumberOfAvailableCopies_textBox.ReadOnly = true;
            this.displayNumberOfAvailableCopies_textBox.Size = new System.Drawing.Size(47, 22);
            this.displayNumberOfAvailableCopies_textBox.TabIndex = 12;
            // 
            // filterByAuthor_label
            // 
            this.filterByAuthor_label.AutoSize = true;
            this.filterByAuthor_label.Location = new System.Drawing.Point(588, 7);
            this.filterByAuthor_label.Name = "filterByAuthor_label";
            this.filterByAuthor_label.Size = new System.Drawing.Size(124, 17);
            this.filterByAuthor_label.TabIndex = 3;
            this.filterByAuthor_label.Text = "Filter list by author";
            // 
            // createNewLoan_btn
            // 
            this.createNewLoan_btn.Location = new System.Drawing.Point(356, 309);
            this.createNewLoan_btn.Name = "createNewLoan_btn";
            this.createNewLoan_btn.Size = new System.Drawing.Size(220, 94);
            this.createNewLoan_btn.TabIndex = 4;
            this.createNewLoan_btn.Text = "Create loan";
            this.createNewLoan_btn.UseVisualStyleBackColor = true;
            this.createNewLoan_btn.Click += new System.EventHandler(this.createNewLoan_btn_Click);
            // 
            // filterListByAuthor_comboBox
            // 
            this.filterListByAuthor_comboBox.FormattingEnabled = true;
            this.filterListByAuthor_comboBox.Location = new System.Drawing.Point(591, 33);
            this.filterListByAuthor_comboBox.Name = "filterListByAuthor_comboBox";
            this.filterListByAuthor_comboBox.Size = new System.Drawing.Size(198, 24);
            this.filterListByAuthor_comboBox.TabIndex = 2;
            this.filterListByAuthor_comboBox.SelectedIndexChanged += new System.EventHandler(this.filterListByAuthor_comboBox_SelectedIndexChanged);
            // 
            // removeBook_btn
            // 
            this.removeBook_btn.Location = new System.Drawing.Point(356, 208);
            this.removeBook_btn.Name = "removeBook_btn";
            this.removeBook_btn.Size = new System.Drawing.Size(220, 95);
            this.removeBook_btn.TabIndex = 3;
            this.removeBook_btn.Text = "Remove book";
            this.removeBook_btn.UseVisualStyleBackColor = true;
            this.removeBook_btn.Click += new System.EventHandler(this.removeBook_btn_Click);
            // 
            // editBook_btn
            // 
            this.editBook_btn.Location = new System.Drawing.Point(356, 108);
            this.editBook_btn.Name = "editBook_btn";
            this.editBook_btn.Size = new System.Drawing.Size(220, 95);
            this.editBook_btn.TabIndex = 2;
            this.editBook_btn.Text = "Edit book";
            this.editBook_btn.UseVisualStyleBackColor = true;
            this.editBook_btn.Click += new System.EventHandler(this.editBook_btn_Click);
            // 
            // booksAdd_btn
            // 
            this.booksAdd_btn.Location = new System.Drawing.Point(356, 7);
            this.booksAdd_btn.Name = "booksAdd_btn";
            this.booksAdd_btn.Size = new System.Drawing.Size(220, 95);
            this.booksAdd_btn.TabIndex = 1;
            this.booksAdd_btn.Text = "Add new book";
            this.booksAdd_btn.UseVisualStyleBackColor = true;
            this.booksAdd_btn.Click += new System.EventHandler(this.booksAdd_btn_Click);
            // 
            // authors_tabPage
            // 
            this.authors_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.authors_tabPage.Controls.Add(this.authorsListView);
            this.authors_tabPage.Controls.Add(this.label15);
            this.authors_tabPage.Controls.Add(this.addNewAuthor_btn);
            this.authors_tabPage.Controls.Add(this.authors_listbox);
            this.authors_tabPage.Location = new System.Drawing.Point(4, 59);
            this.authors_tabPage.Name = "authors_tabPage";
            this.authors_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.authors_tabPage.Size = new System.Drawing.Size(1020, 418);
            this.authors_tabPage.TabIndex = 1;
            this.authors_tabPage.Text = "Authors";
            // 
            // authorsListView
            // 
            this.authorsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookName,
            this.AvailableCompies,
            this.ISBN});
            this.authorsListView.GridLines = true;
            this.authorsListView.Location = new System.Drawing.Point(523, 26);
            this.authorsListView.Name = "authorsListView";
            this.authorsListView.Size = new System.Drawing.Size(404, 367);
            this.authorsListView.TabIndex = 3;
            this.authorsListView.UseCompatibleStateImageBehavior = false;
            this.authorsListView.View = System.Windows.Forms.View.Details;
            this.authorsListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // bookName
            // 
            this.bookName.Text = "Title";
            this.bookName.Width = 47;
            // 
            // AvailableCompies
            // 
            this.AvailableCompies.Text = "Available copies";
            this.AvailableCompies.Width = 116;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 166;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Author information";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // addNewAuthor_btn
            // 
            this.addNewAuthor_btn.Location = new System.Drawing.Point(289, 290);
            this.addNewAuthor_btn.Name = "addNewAuthor_btn";
            this.addNewAuthor_btn.Size = new System.Drawing.Size(228, 103);
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
            this.authors_listbox.SelectedIndexChanged += new System.EventHandler(this.authors_listbox_SelectedIndexChanged);
            // 
            // loans_tabPage
            // 
            this.loans_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.loans_tabPage.Controls.Add(this.groupBox2);
            this.loans_tabPage.Controls.Add(this.ReturnSelectedBookCopy_btn);
            this.loans_tabPage.Controls.Add(this.TotalLoanHistory_radioBtn);
            this.loans_tabPage.Controls.Add(this.ShowAllReturnedBooks_radioBtn);
            this.loans_tabPage.Controls.Add(this.ShowAllCurrentlyLateBooks_radioBtn);
            this.loans_tabPage.Controls.Add(this.ShowAllCurrentLoans_radioBtn);
            this.loans_tabPage.Controls.Add(this.loans_listbox);
            this.loans_tabPage.Location = new System.Drawing.Point(4, 59);
            this.loans_tabPage.Name = "loans_tabPage";
            this.loans_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loans_tabPage.Size = new System.Drawing.Size(1020, 418);
            this.loans_tabPage.TabIndex = 2;
            this.loans_tabPage.Text = "Loans";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.LoanStatus_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.MemberHavingLoan_textBox);
            this.groupBox2.Controls.Add(this.BookCopyTitleLoan_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ReturnDateLoan_texrBox);
            this.groupBox2.Controls.Add(this.AuthorNameLoan_textBox);
            this.groupBox2.Location = new System.Drawing.Point(573, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 189);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Status";
            // 
            // LoanStatus_textBox
            // 
            this.LoanStatus_textBox.Location = new System.Drawing.Point(223, 156);
            this.LoanStatus_textBox.Name = "LoanStatus_textBox";
            this.LoanStatus_textBox.ReadOnly = true;
            this.LoanStatus_textBox.Size = new System.Drawing.Size(171, 22);
            this.LoanStatus_textBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Member";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Return date";
            // 
            // MemberHavingLoan_textBox
            // 
            this.MemberHavingLoan_textBox.Location = new System.Drawing.Point(223, 111);
            this.MemberHavingLoan_textBox.Name = "MemberHavingLoan_textBox";
            this.MemberHavingLoan_textBox.ReadOnly = true;
            this.MemberHavingLoan_textBox.Size = new System.Drawing.Size(171, 22);
            this.MemberHavingLoan_textBox.TabIndex = 11;
            // 
            // BookCopyTitleLoan_textBox
            // 
            this.BookCopyTitleLoan_textBox.Location = new System.Drawing.Point(6, 52);
            this.BookCopyTitleLoan_textBox.Name = "BookCopyTitleLoan_textBox";
            this.BookCopyTitleLoan_textBox.ReadOnly = true;
            this.BookCopyTitleLoan_textBox.Size = new System.Drawing.Size(178, 22);
            this.BookCopyTitleLoan_textBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Author";
            // 
            // ReturnDateLoan_texrBox
            // 
            this.ReturnDateLoan_texrBox.Location = new System.Drawing.Point(9, 108);
            this.ReturnDateLoan_texrBox.Name = "ReturnDateLoan_texrBox";
            this.ReturnDateLoan_texrBox.ReadOnly = true;
            this.ReturnDateLoan_texrBox.Size = new System.Drawing.Size(175, 22);
            this.ReturnDateLoan_texrBox.TabIndex = 12;
            // 
            // AuthorNameLoan_textBox
            // 
            this.AuthorNameLoan_textBox.Location = new System.Drawing.Point(223, 52);
            this.AuthorNameLoan_textBox.Name = "AuthorNameLoan_textBox";
            this.AuthorNameLoan_textBox.ReadOnly = true;
            this.AuthorNameLoan_textBox.Size = new System.Drawing.Size(171, 22);
            this.AuthorNameLoan_textBox.TabIndex = 9;
            // 
            // ReturnSelectedBookCopy_btn
            // 
            this.ReturnSelectedBookCopy_btn.Location = new System.Drawing.Point(286, 293);
            this.ReturnSelectedBookCopy_btn.Name = "ReturnSelectedBookCopy_btn";
            this.ReturnSelectedBookCopy_btn.Size = new System.Drawing.Size(233, 101);
            this.ReturnSelectedBookCopy_btn.TabIndex = 7;
            this.ReturnSelectedBookCopy_btn.Text = "Return selected book copy";
            this.ReturnSelectedBookCopy_btn.UseVisualStyleBackColor = true;
            this.ReturnSelectedBookCopy_btn.Click += new System.EventHandler(this.ReturnSelectedBookCopy_btn_Click);
            // 
            // TotalLoanHistory_radioBtn
            // 
            this.TotalLoanHistory_radioBtn.AutoSize = true;
            this.TotalLoanHistory_radioBtn.Location = new System.Drawing.Point(286, 88);
            this.TotalLoanHistory_radioBtn.Name = "TotalLoanHistory_radioBtn";
            this.TotalLoanHistory_radioBtn.Size = new System.Drawing.Size(162, 21);
            this.TotalLoanHistory_radioBtn.TabIndex = 4;
            this.TotalLoanHistory_radioBtn.TabStop = true;
            this.TotalLoanHistory_radioBtn.Text = "See total loan history";
            this.TotalLoanHistory_radioBtn.UseVisualStyleBackColor = true;
            // 
            // ShowAllReturnedBooks_radioBtn
            // 
            this.ShowAllReturnedBooks_radioBtn.AutoSize = true;
            this.ShowAllReturnedBooks_radioBtn.Location = new System.Drawing.Point(286, 60);
            this.ShowAllReturnedBooks_radioBtn.Name = "ShowAllReturnedBooks_radioBtn";
            this.ShowAllReturnedBooks_radioBtn.Size = new System.Drawing.Size(181, 21);
            this.ShowAllReturnedBooks_radioBtn.TabIndex = 3;
            this.ShowAllReturnedBooks_radioBtn.TabStop = true;
            this.ShowAllReturnedBooks_radioBtn.Text = "Show all returned books";
            this.ShowAllReturnedBooks_radioBtn.UseVisualStyleBackColor = true;
            // 
            // ShowAllCurrentlyLateBooks_radioBtn
            // 
            this.ShowAllCurrentlyLateBooks_radioBtn.AutoSize = true;
            this.ShowAllCurrentlyLateBooks_radioBtn.Location = new System.Drawing.Point(286, 33);
            this.ShowAllCurrentlyLateBooks_radioBtn.Name = "ShowAllCurrentlyLateBooks_radioBtn";
            this.ShowAllCurrentlyLateBooks_radioBtn.Size = new System.Drawing.Size(260, 21);
            this.ShowAllCurrentlyLateBooks_radioBtn.TabIndex = 2;
            this.ShowAllCurrentlyLateBooks_radioBtn.TabStop = true;
            this.ShowAllCurrentlyLateBooks_radioBtn.Text = "Show all late books currently on loan";
            this.ShowAllCurrentlyLateBooks_radioBtn.UseVisualStyleBackColor = true;
            // 
            // ShowAllCurrentLoans_radioBtn
            // 
            this.ShowAllCurrentLoans_radioBtn.AutoSize = true;
            this.ShowAllCurrentLoans_radioBtn.Location = new System.Drawing.Point(286, 6);
            this.ShowAllCurrentLoans_radioBtn.Name = "ShowAllCurrentLoans_radioBtn";
            this.ShowAllCurrentLoans_radioBtn.Size = new System.Drawing.Size(233, 21);
            this.ShowAllCurrentLoans_radioBtn.TabIndex = 1;
            this.ShowAllCurrentLoans_radioBtn.TabStop = true;
            this.ShowAllCurrentLoans_radioBtn.Text = "Show all books currently on loan";
            this.ShowAllCurrentLoans_radioBtn.UseVisualStyleBackColor = true;
            this.ShowAllCurrentLoans_radioBtn.CheckedChanged += new System.EventHandler(this.ShowAllCurrentLoans_radioBtn_CheckedChanged);
            // 
            // loans_listbox
            // 
            this.loans_listbox.FormattingEnabled = true;
            this.loans_listbox.ItemHeight = 16;
            this.loans_listbox.Location = new System.Drawing.Point(6, 6);
            this.loans_listbox.Name = "loans_listbox";
            this.loans_listbox.Size = new System.Drawing.Size(274, 388);
            this.loans_listbox.TabIndex = 0;
            this.loans_listbox.SelectedIndexChanged += new System.EventHandler(this.loans_listbox_SelectedIndexChanged);
            // 
            // members_tabPage
            // 
            this.members_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.members_tabPage.Controls.Add(this.MemberListView);
            this.members_tabPage.Controls.Add(this.DisplayMemberDept_listBox);
            this.members_tabPage.Controls.Add(this.DisplayMemberPersonalId_textBox);
            this.members_tabPage.Controls.Add(this.DisplayMemberNameMemberPage_textBox);
            this.members_tabPage.Controls.Add(this.label14);
            this.members_tabPage.Controls.Add(this.label13);
            this.members_tabPage.Controls.Add(this.label12);
            this.members_tabPage.Controls.Add(this.label11);
            this.members_tabPage.Controls.Add(this.addNewMemberPopup_btn);
            this.members_tabPage.Controls.Add(this.members_listbox);
            this.members_tabPage.Location = new System.Drawing.Point(4, 59);
            this.members_tabPage.Name = "members_tabPage";
            this.members_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.members_tabPage.Size = new System.Drawing.Size(1020, 418);
            this.members_tabPage.TabIndex = 3;
            this.members_tabPage.Text = "Members";
            // 
            // MemberListView
            // 
            this.MemberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.DueDate});
            this.MemberListView.GridLines = true;
            this.MemberListView.Location = new System.Drawing.Point(530, 83);
            this.MemberListView.Name = "MemberListView";
            this.MemberListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MemberListView.Size = new System.Drawing.Size(447, 311);
            this.MemberListView.TabIndex = 9;
            this.MemberListView.UseCompatibleStateImageBehavior = false;
            this.MemberListView.View = System.Windows.Forms.View.Details;
            this.MemberListView.SelectedIndexChanged += new System.EventHandler(this.MemberListView_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 222;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 134;
            // 
            // DueDate
            // 
            this.DueDate.Text = "Return date";
            this.DueDate.Width = 216;
            // 
            // DisplayMemberDept_listBox
            // 
            this.DisplayMemberDept_listBox.Location = new System.Drawing.Point(919, 30);
            this.DisplayMemberDept_listBox.Name = "DisplayMemberDept_listBox";
            this.DisplayMemberDept_listBox.ReadOnly = true;
            this.DisplayMemberDept_listBox.Size = new System.Drawing.Size(58, 22);
            this.DisplayMemberDept_listBox.TabIndex = 8;
            // 
            // DisplayMemberPersonalId_textBox
            // 
            this.DisplayMemberPersonalId_textBox.Location = new System.Drawing.Point(757, 30);
            this.DisplayMemberPersonalId_textBox.Name = "DisplayMemberPersonalId_textBox";
            this.DisplayMemberPersonalId_textBox.ReadOnly = true;
            this.DisplayMemberPersonalId_textBox.Size = new System.Drawing.Size(141, 22);
            this.DisplayMemberPersonalId_textBox.TabIndex = 7;
            // 
            // DisplayMemberNameMemberPage_textBox
            // 
            this.DisplayMemberNameMemberPage_textBox.Location = new System.Drawing.Point(533, 30);
            this.DisplayMemberNameMemberPage_textBox.Name = "DisplayMemberNameMemberPage_textBox";
            this.DisplayMemberNameMemberPage_textBox.ReadOnly = true;
            this.DisplayMemberNameMemberPage_textBox.Size = new System.Drawing.Size(207, 22);
            this.DisplayMemberNameMemberPage_textBox.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(530, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Current loans by member";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(916, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Debt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(754, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Personal ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name";
            // 
            // addNewMemberPopup_btn
            // 
            this.addNewMemberPopup_btn.Location = new System.Drawing.Point(285, 309);
            this.addNewMemberPopup_btn.Name = "addNewMemberPopup_btn";
            this.addNewMemberPopup_btn.Size = new System.Drawing.Size(227, 85);
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
            this.members_listbox.SelectedIndexChanged += new System.EventHandler(this.members_listbox_SelectedIndexChanged);
            // 
            // bookCopies_tabPage
            // 
            this.bookCopies_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.bookCopies_tabPage.Controls.Add(this.TotalNumberOfCopies_textbox);
            this.bookCopies_tabPage.Controls.Add(this.AmountOfCopiesOnLoan_textbox);
            this.bookCopies_tabPage.Controls.Add(this.AmountOfCopiesInStore_textBox);
            this.bookCopies_tabPage.Controls.Add(this.AuthorNameFromBookCopy_textbox);
            this.bookCopies_tabPage.Controls.Add(this.label19);
            this.bookCopies_tabPage.Controls.Add(this.label18);
            this.bookCopies_tabPage.Controls.Add(this.label17);
            this.bookCopies_tabPage.Controls.Add(this.label16);
            this.bookCopies_tabPage.Controls.Add(this.addNewBookCopy_btn);
            this.bookCopies_tabPage.Controls.Add(this.bookCopies_listbox);
            this.bookCopies_tabPage.Location = new System.Drawing.Point(4, 59);
            this.bookCopies_tabPage.Name = "bookCopies_tabPage";
            this.bookCopies_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookCopies_tabPage.Size = new System.Drawing.Size(1020, 418);
            this.bookCopies_tabPage.TabIndex = 4;
            this.bookCopies_tabPage.Text = "Book copies";
            // 
            // addNewBookCopy_btn
            // 
            this.addNewBookCopy_btn.Location = new System.Drawing.Point(284, 308);
            this.addNewBookCopy_btn.Name = "addNewBookCopy_btn";
            this.addNewBookCopy_btn.Size = new System.Drawing.Size(211, 86);
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
            this.bookCopies_listbox.SelectedIndexChanged += new System.EventHandler(this.bookCopies_listbox_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(283, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Author";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Number of copies";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(283, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Copies on loan";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(283, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 17);
            this.label19.TabIndex = 5;
            this.label19.Text = "Copies in storage";
            // 
            // AuthorNameFromBookCopy_textbox
            // 
            this.AuthorNameFromBookCopy_textbox.Location = new System.Drawing.Point(286, 27);
            this.AuthorNameFromBookCopy_textbox.Name = "AuthorNameFromBookCopy_textbox";
            this.AuthorNameFromBookCopy_textbox.ReadOnly = true;
            this.AuthorNameFromBookCopy_textbox.Size = new System.Drawing.Size(209, 22);
            this.AuthorNameFromBookCopy_textbox.TabIndex = 6;
            // 
            // AmountOfCopiesInStore_textBox
            // 
            this.AmountOfCopiesInStore_textBox.Location = new System.Drawing.Point(286, 72);
            this.AmountOfCopiesInStore_textBox.Name = "AmountOfCopiesInStore_textBox";
            this.AmountOfCopiesInStore_textBox.ReadOnly = true;
            this.AmountOfCopiesInStore_textBox.Size = new System.Drawing.Size(101, 22);
            this.AmountOfCopiesInStore_textBox.TabIndex = 7;
            // 
            // AmountOfCopiesOnLoan_textbox
            // 
            this.AmountOfCopiesOnLoan_textbox.Location = new System.Drawing.Point(287, 117);
            this.AmountOfCopiesOnLoan_textbox.Name = "AmountOfCopiesOnLoan_textbox";
            this.AmountOfCopiesOnLoan_textbox.ReadOnly = true;
            this.AmountOfCopiesOnLoan_textbox.Size = new System.Drawing.Size(100, 22);
            this.AmountOfCopiesOnLoan_textbox.TabIndex = 8;
            // 
            // TotalNumberOfCopies_textbox
            // 
            this.TotalNumberOfCopies_textbox.Location = new System.Drawing.Point(287, 162);
            this.TotalNumberOfCopies_textbox.Name = "TotalNumberOfCopies_textbox";
            this.TotalNumberOfCopies_textbox.ReadOnly = true;
            this.TotalNumberOfCopies_textbox.Size = new System.Drawing.Size(100, 22);
            this.TotalNumberOfCopies_textbox.TabIndex = 9;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 511);
            this.Controls.Add(this.tabPageForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.tabPageForm.ResumeLayout(false);
            this.books_tabPage.ResumeLayout(false);
            this.books_tabPage.PerformLayout();
            this.booksInformation_groupBox.ResumeLayout(false);
            this.booksInformation_groupBox.PerformLayout();
            this.authors_tabPage.ResumeLayout(false);
            this.authors_tabPage.PerformLayout();
            this.loans_tabPage.ResumeLayout(false);
            this.loans_tabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.members_tabPage.ResumeLayout(false);
            this.members_tabPage.PerformLayout();
            this.bookCopies_tabPage.ResumeLayout(false);
            this.bookCopies_tabPage.PerformLayout();
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
        private System.Windows.Forms.RadioButton TotalLoanHistory_radioBtn;
        private System.Windows.Forms.RadioButton ShowAllReturnedBooks_radioBtn;
        private System.Windows.Forms.RadioButton ShowAllCurrentlyLateBooks_radioBtn;
        private System.Windows.Forms.RadioButton ShowAllCurrentLoans_radioBtn;
        private System.Windows.Forms.Button ReturnSelectedBookCopy_btn;
        private System.Windows.Forms.GroupBox booksInformation_groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displayAuthorBooks_textBox;
        private System.Windows.Forms.TextBox displayNumberOfAvailableCopies_textBox;
        private System.Windows.Forms.TextBox displayISBNBooks_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayTitleBooks_textBox;
        private System.Windows.Forms.RichTextBox displayDescriptionBooks_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LoanStatus_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MemberHavingLoan_textBox;
        private System.Windows.Forms.TextBox BookCopyTitleLoan_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReturnDateLoan_texrBox;
        private System.Windows.Forms.TextBox AuthorNameLoan_textBox;
        private System.Windows.Forms.TextBox DisplayMemberDept_listBox;
        private System.Windows.Forms.TextBox DisplayMemberPersonalId_textBox;
        private System.Windows.Forms.TextBox DisplayMemberNameMemberPage_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView MemberListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ListView authorsListView;
        private System.Windows.Forms.ColumnHeader bookName;
        private System.Windows.Forms.ColumnHeader AvailableCompies;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TotalNumberOfCopies_textbox;
        private System.Windows.Forms.TextBox AmountOfCopiesOnLoan_textbox;
        private System.Windows.Forms.TextBox AmountOfCopiesInStore_textBox;
        private System.Windows.Forms.TextBox AuthorNameFromBookCopy_textbox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

