using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Services;

namespace Library
{
    public partial class EditBookForm : Form
    {

        private Book _book = new Book();
        private AuthorService _authorService;
        //private AuthorService _authorService;
        //private BookCopyService _bookCopyService;

        public EditBookForm(Book book, AuthorService authorService)
        {
            _book.Id = book.Id;
            _book.BookTitle = book.BookTitle;
            _book.BookAuthor = book.BookAuthor;
            _book.BookDescription = book.BookDescription;
            _book.BookIsbn = book.BookIsbn;
            _authorService = authorService;
            
            InitializeComponent();

        }
        private void EditBookForm_Load(object sender, EventArgs e)
        {
            editBookTitle_textbox.Text = _book.BookTitle;
            editBookDescription_richTextBox.Text = _book.BookDescription;

            foreach(Author author in _authorService.All()) { //FRÅGA OM DETTA IMORN, VARFÖR GÅR DET EJ??
                if(author!=null)
                    editAuthors_comboBox.Items.Add(author);
            }

            editBookIsbn_textbox.Text = _book.BookIsbn;

        }

        public void TextGotFocus(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void editAuthors_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
