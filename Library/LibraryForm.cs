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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {

    public partial class LibraryForm : Form {

        private BookService _bookService;
        private BookCopyService _bookCopyService;
        private LoanService _loanService;
        private AuthorService _authorService;
        private MemberService _memberService;

        public LibraryForm() {
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

        private void ListAllBooks() {
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
            foreach (Loan loan in _loanService.All().Where(b => b.DueDate != null))
            {
                //loans_listbox.Items.Add(loan.BookCopy.Book.BookTitle);
                loans_listbox.Items.Add(loan);
            }
        }

        private void ListAllBookCopies()
        {
            foreach (BookCopy bookCopy in _bookCopyService.All())
            {
                bookCopies_listbox.Items.Add(bookCopy);
            }
        }

        private void booksAdd_btn_Click(object sender, EventArgs e)
        {
            var form = new AddBookForm(_bookService, _bookCopyService, _authorService);
            form.Show(this);
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            ListAllBooks();
            ListAllAuthors();

        }

        private void removeBook_btn_Click(object sender, EventArgs e)
        {

            Book selectedBookToRemove = (Book) books_listbox.SelectedItem;
            _bookService.RemoveBook(selectedBookToRemove);
        }

        private void books_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editBook_btn_Click(object sender, EventArgs e)
        {
            Book findBook = (Book) books_listbox.SelectedItem;
            Book selectedBookToEdit = _bookService.EditBook(findBook.Id);
            var form = new EditBookForm(selectedBookToEdit, _authorService);
            form.Show(this);
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
            var form = new CreateLoanForms(_memberService, _loanService, _bookCopyService, _bookService);
            form.Show(this);
        }

        private void filterListByAuthor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            books_listbox.Items.Clear();
            Author author = (Author) filterListByAuthor_comboBox.SelectedItem;
            foreach (Book book in _bookService.GetBookByAuthor(author.AuthorName))
            {
                books_listbox.Items.Add(book);
            }
        }

    }


}
