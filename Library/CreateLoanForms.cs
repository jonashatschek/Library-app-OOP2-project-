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
    public partial class CreateLoanForms : Form
    {
        private MemberService _memberService;
        private BookCopyService _bookCopyService;
        private LoanService _loanService;
        private BookService _bookService;

        public CreateLoanForms(MemberService memberService, LoanService loanService, BookCopyService bookCopyService, BookService bookService)
        {
            InitializeComponent();
            _memberService = memberService;
            _bookCopyService = bookCopyService;
            _loanService = loanService;
            _bookService = bookService;
        }

        private void loanTaker_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void availableBooks_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateLoanForms_Load(object sender, EventArgs e)
        {
            foreach (Member member in _memberService.All())
            {
                loanTaker_comboBox.Items.Add(member);
            }

            foreach (BookCopy bookCopy in _bookCopyService.CopiesNotOnLoan())
            {
                availableBooks_comboBox.Items.Add(bookCopy);
            }
        }

        private void createLoan_btn_Click(object sender, EventArgs e)
        {
            Member loanTaker = (Member) loanTaker_comboBox.SelectedItem;
            BookCopy bookForLoan = (BookCopy) availableBooks_comboBox.SelectedItem;
            _loanService.AddNewLoan(loanTaker, bookForLoan);
        }
    }
}
