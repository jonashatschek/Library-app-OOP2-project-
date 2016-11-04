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
    /// class for creating loans
    /// </summary>
    public partial class CreateLoanForms : Form
    {
        private MemberService _memberService;
        private BookCopyService _bookCopyService;
        private LoanService _loanService;

        /// <summary>
        /// class const
        /// </summary>
        /// <param name="memberService">member service object</param>
        /// <param name="loanService">loan service object</param>
        /// <param name="bookCopyService">bookcopy object</param>
        public CreateLoanForms(MemberService memberService, LoanService loanService, BookCopyService bookCopyService)
        {
            InitializeComponent();
            _memberService = memberService;
            _bookCopyService = bookCopyService;
            _loanService = loanService;
        }

        private void loanTaker_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void availableBooks_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// fills up comboboxes when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateLoanForms_Load(object sender, EventArgs e)
        {
            foreach (Member member in _memberService.All())
            {
                loanTaker_comboBox.Items.Add(member);
            }

            foreach (BookCopy bookCopy in _bookCopyService.AllBookCopiesNotOnLoan())
            {
                availableBooks_comboBox.Items.Add(bookCopy);
            }
        }

        /// <summary>
        /// sets the member and bookcopy from the comboboxes and calls the AddNewLoan-method in loan service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createLoan_btn_Click(object sender, EventArgs e)
        {
            Member loanTaker = (Member) loanTaker_comboBox.SelectedItem;
            BookCopy bookForLoan = (BookCopy) availableBooks_comboBox.SelectedItem;
            _loanService.AddNewLoan(loanTaker, bookForLoan);

            this.Close();
        }

        /// <summary>
        /// closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelLoan_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
