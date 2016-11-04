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
    /// class for adding new books to the database
    /// </summary>
    public partial class AddBookForm : Form
    {
        private BookService _bookService;
        private AuthorService _authorService;

        public AddBookForm(BookService bookservice, AuthorService authorService)
        {
            _bookService = bookservice;
            _authorService = authorService;
            InitializeComponent();
        }

        /// <summary>
        /// sets all values correctly when user wishes to add new book and sends it to bookservice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void booksAdd_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string correctIsbn = checkIsbn(addBookIsbn_textbox.Text);
                Author chosenAuthor = (Author) addNewBookAllAuthors_comboBox.SelectedItem;
                _bookService.AddNewBook(addBookTitle_textbox.Text, correctIsbn,
                    addBookDescription_richTextBox.Text, chosenAuthor);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Fields title and author cannot be left blank");
            }
        }

        /// <summary>
        /// when the form is loaded the combobox with authors fills up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBookForm_Load(object sender, EventArgs e)
        {
            foreach (Author author in _authorService.All())
            {
                addNewBookAllAuthors_comboBox.Items.Add(author);
            }
        }

        /// <summary>
        /// checks the format of the isbn
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        private string checkIsbn(string isbn)
        {
            string reFormattedIsbn;
            if (isbn.Length == 13)
            {
                reFormattedIsbn = isbn.Insert(3, "-").Insert(5, "-").Insert(9, "-").Insert(16, "-");
                return reFormattedIsbn;
            }
            else
                MessageBox.Show("Wrong input format. ISBN has to be 13 numbers. Please edit input.");
            return "Invalid ISBN";
        }

        private void addNewBookAllAuthors_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
