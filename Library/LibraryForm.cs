using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {

    /// <summary>
    /// class constructor
    /// </summary>
    public partial class LibraryForm : Form
    {

        /// <summary>
        /// creates objects for each service
        /// </summary>
        private BookService _bookService;
        private BookCopyService _bookCopyService;
        private LoanService _loanService;
        private AuthorService _authorService;
        private MemberService _memberService;

        public LibraryForm()
        {
            InitializeComponent();

            RepositoryFactory repoFactory = new RepositoryFactory();
            _bookService = new BookService(repoFactory);
            _bookCopyService = new BookCopyService(repoFactory);
            _loanService = new LoanService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _memberService = new MemberService(repoFactory);
            _bookService.Updated += _bookService_Updated; //subscribes to event and calls _bookService_Updated-method
            _authorService.Updated += _authorService_Updated;
            _memberService.Updated += _memberService_Updated;
            _bookCopyService.Updated += _bookCopyService_Updated;
            _loanService.Updated += _loanService_Updated;

        }

        private void _loanService_Updated(object sender, EventArgs e)
        {
            loans_listbox.Items.Clear();
            ListAllLoans();
        }

        private void _bookCopyService_Updated(object sender, EventArgs e)
        {
            bookCopies_listbox.Items.Clear();
            ListAllBookCopies();
        }

        private void _memberService_Updated(object sender, EventArgs e)
        {
            members_listbox.Items.Clear();
            ListAllMembers();
        }

        private void _authorService_Updated(object sender, EventArgs e)
        {
            authors_listbox.Items.Clear();
            ListAllAuthors();
        }

        private void _bookService_Updated(object sender, EventArgs e)
        {
            books_listbox.Items.Clear();
            ListAllBooks();
        }

        private void ListAllAuthors()
        {
            foreach (Author author in _authorService.All())
            {
                authors_listbox.Items.Add(author);
                filterListByAuthor_comboBox.Items.Add(author);
            }
        }

        private void ListAllBooks()
        {
            foreach (Book book in _bookService.All())
            {
                books_listbox.Items.Add(book);
            }
        }

        private void ListAllMembers()
        {
            foreach (Member member in _memberService.All())
            {
                members_listbox.Items.Add(member);
            }
        }

        private void ListAllLoans()
        {
            foreach (Loan loan in _loanService.All())
            {
                loans_listbox.Items.Add(loan);
            }
        }

        private void ListAllBookCopies()
        {
            foreach (Book book in _bookService.AllBooksWithAtLeastOneCopy())
            {
                bookCopies_listbox.Items.Add(book);
            }
        }

        private void booksAdd_btn_Click(object sender, EventArgs e)
        {
            var form = new AddBookForm(_bookService, _authorService);
            form.Show(this);
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            ListAllBooks();
            ListAllAuthors();
            ListAllMembers();
            ListAllBookCopies();
            ListAllLoans();
            MemberListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            MemberListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void removeBook_btn_Click(object sender, EventArgs e)
        {

            Book selectedBookToRemove = (Book) books_listbox.SelectedItem;
            _bookService.RemoveBook(selectedBookToRemove);
        }

        private void books_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(books_listbox.SelectedItems.Count != 0) {

                Book selectedBook = (Book) books_listbox.SelectedItem;
                displayTitleBooks_textBox.Text = selectedBook.BookTitle;
                displayAuthorBooks_textBox.Text = selectedBook.BookAuthor.AuthorName;
                displayISBNBooks_textBox.Text = selectedBook.BookIsbn;

                var availableBookCopies = _bookCopyService.AllCopiesOfSpecificBookNotOnLoan(selectedBook);
                displayNumberOfAvailableCopies_textBox.Text = Convert.ToString(availableBookCopies.Count());
                displayDescriptionBooks_textBox.Text = selectedBook.BookDescription;
            }
        }

        private void editBook_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Book findBook = (Book) books_listbox.SelectedItem;
                Book selectedBookToEdit = _bookService.EditBook(findBook.Id);
                var form = new EditBookForm(selectedBookToEdit, _authorService);
                form.Show(this);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to select an item to edit first");
            }
        }

        private void addNewAuthor_btn_Click(object sender, EventArgs e)
        {
            var form = new AddNewAuthorForm(_authorService);
            form.Show(this);
        }

        private void addNewMemberPopup_btn_Click(object sender, EventArgs e)
        {
            var form = new AddNewMemberForm(_memberService);
            form.Show(this);
        }

        private void addNewBookCopy_btn_Click(object sender, EventArgs e)
        {
            var form = new AddNewBookCopyForm(_bookCopyService, _bookService);
            form.Show(this);
        }

        private void createNewLoan_btn_Click(object sender, EventArgs e)
        {
            var form = new CreateLoanForms(_memberService, _loanService, _bookCopyService);
            form.Show(this);
        }

        private void filterListByAuthor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            books_listbox.Items.Clear();
            Author author = (Author) filterListByAuthor_comboBox.SelectedItem;

            foreach (Book book in _bookService.GetBookByAuthor(author.Id))
            {
                books_listbox.Items.Add(book);
            }
        }

        private void ShowAllCurrentLoans_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Loan loan in _loanService.All())
            {
                loans_listbox.Items.Add(loan);
            }
        }

        private void ReturnSelectedBookCopy_btn_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = (Loan) loans_listbox.SelectedItem;
            _loanService.ReturnBookCopy(selectedLoan);
        }

        private void books_tabPage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void displayTitleBooks_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loans_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loans_listbox.SelectedItems.Count != 0) {

                Loan selectedItem = (Loan) loans_listbox.SelectedItem;
                BookCopyTitleLoan_textBox.Text = selectedItem.BookCopy.Book.BookTitle;
                AuthorNameLoan_textBox.Text = selectedItem.BookCopy.Book.BookAuthor.AuthorName;
                MemberHavingLoan_textBox.Text = selectedItem.Member.MemberName;
                ReturnDateLoan_texrBox.Text = selectedItem.DueDate.Date.ToShortDateString();

                if (selectedItem.isOverdue)
                {
                    LoanStatus_textBox.Text = String.Format(@"Overdue [by {0} days]",
                        selectedItem.TimeOfReturn.Value.Subtract(selectedItem.DueDate.Date).Days);

                }
                else if (!selectedItem.TimeOfReturn.HasValue)
                    LoanStatus_textBox.Text = @"On loan";
                else
                {
                    LoanStatus_textBox.Text = String.Format(@"Returned [{0}]", selectedItem.TimeOfReturn.Value.ToShortDateString());
                }
            }
        }

        private void members_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(members_listbox.SelectedItems.Count != 0) {
                MemberListView.Items.Clear();
                Member selectedItem = (Member) members_listbox.SelectedItem;

                DisplayMemberNameMemberPage_textBox.Text = selectedItem.MemberName;
                DisplayMemberPersonalId_textBox.Text = selectedItem.PersonalId;
                DisplayMemberDept_listBox.Text = selectedItem.Debt.ToString();
                ListViewItem lvi;
                foreach(Loan loan in _loanService.GetAllLoansByMember(selectedItem.MemberId)) { 
                    lvi = new ListViewItem(loan.BookCopy.Book.BookTitle);
                    lvi.SubItems.Add(loan.BookCopy.Book.BookAuthor.AuthorName);
                    lvi.SubItems.Add(loan.DueDate.Date.ToShortDateString());
                    MemberListView.Items.Add(lvi);
                }

                MemberListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                MemberListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }



        }

        private void MemberListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void authors_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(authors_listbox.SelectedItems.Count != 0) { 
                authorsListView.Items.Clear();
                Author author = (Author) authors_listbox.SelectedItem;

                foreach (Book book in _bookService.GetBookByAuthor(author.Id))
                {
                    ListViewItem lvi;
                    lvi = new ListViewItem(book.BookTitle);
                    var availableBookCopies = _bookCopyService.AllCopiesOfSpecificBookNotOnLoan(book);
                    lvi.SubItems.Add(Convert.ToString(availableBookCopies.Count()));
                    lvi.SubItems.Add(book.BookIsbn);
                    authorsListView.Items.Add(lvi);
                }

                authorsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                authorsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }

        }

        private void bookCopies_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book = (Book) bookCopies_listbox.SelectedItem;
            AuthorNameFromBookCopy_textbox.Text = book.BookAuthor.AuthorName;

            IEnumerable<BookCopy> retrievedTotalNumberOfBookCopies = _bookCopyService.GetBookCopiesByBook(book);
            int totalNumberOfBookCopies = retrievedTotalNumberOfBookCopies.Count();
            TotalNumberOfCopies_textbox.Text = Convert.ToString(totalNumberOfBookCopies);

            IEnumerable<BookCopy> retrievedBookCopiesNotOnLoan = _bookCopyService.AllCopiesOfSpecificBookNotOnLoan(book);
            int numberOfBookCopiesNotOnLoan = retrievedBookCopiesNotOnLoan.Count();
            AmountOfCopiesInStore_textBox.Text = Convert.ToString(numberOfBookCopiesNotOnLoan);

            AmountOfCopiesOnLoan_textbox.Text = Convert.ToString(totalNumberOfBookCopies - numberOfBookCopiesNotOnLoan);
        }
    }
}



