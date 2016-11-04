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
    /// <summary>
    /// class for adding new authors to the database
    /// </summary>
    public partial class AddNewAuthorForm : Form
    {
        private AuthorService _authorService;

        public AddNewAuthorForm(AuthorService authorService)
        {
            InitializeComponent();
            _authorService = authorService;
        }

        private void AddNewAuthorForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// get the name of the author and sends it to authorservice on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewAuthor_btn_Click(object sender, EventArgs e)
        {
            _authorService.AddNewAuthor(addNewAuthor_textbox.Text);
            this.Close();
        }
    }
}
