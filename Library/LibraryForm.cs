using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
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

        }

        private void _bookService_Updated(object sender, EventArgs e)
        {
            books_listbox.Items.Clear();
            ListAllBooks();
        }

        private void ListAllBooks() {
            foreach (Book book in _bookService.All()) {
                books_listbox.Items.Add(book);
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
        }

        private void removeBook_btn_Click(object sender, EventArgs e)
        {

            Book selectedBook = (Book) books_listbox.SelectedItem;
            _bookService.RemoveBook(selectedBook);
        }

        private void books_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editBook_btn_Click(object sender, EventArgs e)
        {
            var form = new EditBookForm(_bookService, _authorService, _bookCopyService);
            form.Show(this); 
        }
    }


}
