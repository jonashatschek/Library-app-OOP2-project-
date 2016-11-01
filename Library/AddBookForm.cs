using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Services;

namespace Library
{
    public partial class AddBookForm : Form
    {
        private BookService _bookService;
        private BookCopyService _bookCopyService;
        private AuthorService _authorService;
        Book _book = new Book();

        public AddBookForm(BookService bookservice, BookCopyService bookCopyService, AuthorService authorService)
        {
            _bookService = bookservice;
            _bookCopyService = bookCopyService;
            _authorService = authorService;
            InitializeComponent();
        }

        private void booksAdd_btn_Click(object sender, EventArgs e)
        {
            _book = _bookService.AddNewBook(addBookTitle_textbox.Text, addBookIsbn_textbox.Text, addBookDescription_richTextBox.Text, addNewBookAllAuthors_comboBox.SelectedItem.ToString());
            _bookCopyService.AddNewBookCopy(_book);
            this.Close();
        }


        private void AddBookForm_Load(object sender, EventArgs e)
        {
            foreach (Author author in _authorService.All())
            {
                addNewBookAllAuthors_comboBox.Items.Add(author);
            }
        }
    }
    /*
    public partial class EditBookForm : Form
    {
        private BookService _book;
        private AuthorService _author;
        private BookCopyService _bookCopy;

        public EditBookForm (BookService book, AuthorService author, BookCopyService bookCopy)
        {
            _book = book;
            _author = author;
            _bookCopy = bookCopy;

        }
    }
    */
}
