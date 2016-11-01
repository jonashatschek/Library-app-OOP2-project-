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
    public partial class AddNewBookCopyForm : Form
    {
        private BookCopyService _bookCopyService;
        private BookService _bookService;
        Book tempBook = new Book();
        BookCopy tempBookCopy = new BookCopy();

        public AddNewBookCopyForm(BookCopyService bookCopyService, BookService bookService)
        {
            InitializeComponent();
            _bookCopyService = bookCopyService;
            _bookService = bookService;
            _bookCopyService.Updated += _bookCopyService_Updated;
        }

        private void _bookCopyService_Updated(object sender, EventArgs e)
        {
            seeBookCopiesByBook_listBox.Items.Clear();
            tempBook = (Book)AddBookCopy_comboBox.SelectedItem;
            _bookCopyService.GetBookCopiesByBookId(tempBook.Id);

            foreach (BookCopy bookCopy in _bookCopyService.GetBookCopiesByBookId(tempBook.Id))
            {
                seeBookCopiesByBook_listBox.Items.Add(bookCopy);
            }

        }

        private void AddNewBookCopyForm_Load(object sender, EventArgs e)
        {
            foreach (Book book in _bookService.All())
            {
                AddBookCopy_comboBox.Items.Add(book);
            }
        }

        private void seeBookCopiesByBook_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddBookCopy_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seeBookCopiesByBook_listBox.Items.Clear();
            tempBook = (Book)AddBookCopy_comboBox.SelectedItem;
            foreach (BookCopy bookCopy in _bookCopyService.GetBookCopiesByBookId(tempBook.Id))
            {
                seeBookCopiesByBook_listBox.Items.Add(bookCopy);
            }

        }

        private void addNewBookCopy_btn_Click(object sender, EventArgs e)
        {
            tempBook = (Book) AddBookCopy_comboBox.SelectedItem;
            _bookCopyService.AddNewBookCopy(tempBook);
        }

        private void removeBookCopy_btn_Click(object sender, EventArgs e)
        {
            tempBookCopy = (BookCopy) seeBookCopiesByBook_listBox.SelectedItem;
            _bookCopyService.RemoveBookCopy(tempBookCopy.BookCopyId);
        }
    }
}
