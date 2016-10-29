using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Services;

namespace Library
{
    public partial class EditBookForm : Form
    {

        private BookService _bookService;
        private AuthorService _authorService;
        private BookCopyService _bookCopyService;

        public EditBookForm(BookService bookService, AuthorService authorService, BookCopyService bookCopyService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _bookCopyService = bookCopyService;
            InitializeComponent();

        }
        private void EditBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
