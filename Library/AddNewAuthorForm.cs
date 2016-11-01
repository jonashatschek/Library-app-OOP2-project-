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

        private void addNewAuthor_btn_Click(object sender, EventArgs e)
        {
            _authorService.AddNewAuthor(addNewAuthor_textbox.Text);
            this.Close();
        }
    }
}
