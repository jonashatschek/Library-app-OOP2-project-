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
    /// <summary>
    /// class for adding a new bookcopy
    /// </summary>
    public partial class AddNewBookCopyForm : Form
    {
        private BookCopyService _bookCopyService;
        private BookService _bookService;
        Book tempBook = new Book();
        BookCopy tempBookCopy = new BookCopy();

        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="bookCopyService">sent in bookcopyservice object</param>
        /// <param name="bookService">sent in bookservice object</param>
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
            Book tempBook = (Book)AddBookCopy_comboBox.SelectedItem;
            _bookCopyService.GetBookCopiesByBookId(tempBook.Id);

            foreach (BookCopy bookCopy in _bookCopyService.GetBookCopiesByBookId(tempBook.Id))
            {
                seeBookCopiesByBook_listBox.Items.Add(bookCopy);
            }

        }

        /// <summary>
        /// puts the values in the combobox when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// when a value is selected in the combobox, the value gets extracted and sent to the book copy repository which is displayed by a listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBookCopy_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AddBookCopy_comboBox.SelectedItem != null) { 
                seeBookCopiesByBook_listBox.Items.Clear();
                tempBook = (Book)AddBookCopy_comboBox.SelectedItem;
                foreach (BookCopy bookCopy in _bookCopyService.GetBookCopiesByBookId(tempBook.Id))
                {
                    seeBookCopiesByBook_listBox.Items.Add(bookCopy);
                }
            }
        }

        /// <summary>
        /// adds a new bookcopy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewBookCopy_btn_Click(object sender, EventArgs e)
        {
            tempBook = (Book) AddBookCopy_comboBox.SelectedItem;
            _bookCopyService.AddNewBookCopy(tempBook);
        }

        /// <summary>
        /// removes a bookcopy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeBookCopy_btn_Click(object sender, EventArgs e)
        {
            tempBookCopy = (BookCopy) seeBookCopiesByBook_listBox.SelectedItem;
            _bookCopyService.RemoveBookCopy(tempBookCopy.BookCopyId);
        }

        private void doneNewBookCopy_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
