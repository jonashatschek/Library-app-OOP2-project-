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

        }

        private void ListAllBooks() {
            foreach (Book book in _bookService.All()) {
                books_listbox.Items.Add(book);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void booksAdd_btn_Click(object sender, EventArgs e)
        {
            _bookService.AddNewBook("jonas book", new Author(), "good stuff!", 417 );
            var form = new PopupForm();
            form.Show(this);
            //TODO: KEEP IMPLEMENTING THE POPUPFORM!!!!
            //adds into database but does not write out. I suspect its missing some good authorInfo =)
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            ListAllBooks();
        }
    }
}
