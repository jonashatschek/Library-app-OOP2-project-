using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    public class LoanService : IService
    {
        LoanRepository _loanRepository;
        public event EventHandler Updated;
        Loan _loan = new Loan();


        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        /// <summary>
        /// calls the Add method in the Loan repository sending in a new object
        /// </summary>
        /// <param name="member">member taking the loan</param>
        /// <param name="bookCopy">book copy to be loaned out</param>
        public void AddNewLoan(Member member, BookCopy bookCopy)
        {
            _loan.Member = member;
            _loan.BookCopy = bookCopy;
            _loan.DueDate = DateTime.Today.AddDays(15); //sets the due date-time to 15 days from today
            _loan.TimeOfLoan = DateTime.Today;
            _loan.TimeOfReturn = null;

            _loanRepository.Add(_loan);

            OnUpdated();
        }

        /// <summary>
        /// calls the All-method in loan repository
        /// </summary>
        /// <returns>a collection of all Loan type objects in database</returns>
        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

        /// <summary>
        /// returns a book copy to the library after a loan
        /// </summary>
        /// <param name="loan">loan to be returned</param>
        public void ReturnBookCopy(Loan loan)
        {
            try
            {
                Loan foundLoan = _loanRepository.Find(loan.LoanId);
                foundLoan.TimeOfReturn = DateTime.Today;
                TimeSpan checkIfOverdue = foundLoan.TimeOfReturn.Value.Subtract(foundLoan.DueDate.Date); //checks if the book is over due

                if (checkIfOverdue.Days > 0)
                {
                    foundLoan.isOverdue = true;
                    foundLoan.Member.Debt += Convert.ToInt32(checkIfOverdue.Days)*10; //gives the member 10 kr fine for each day after due date
                }

                foundLoan.isOverdue = false;

                _loanRepository.Edit(foundLoan);

                OnUpdated();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to select an item to return");
            }
        }

        /// <summary>
        /// calls a method in the loan repository to get all loans by a member
        /// </summary>
        /// <param name="member">Member object</param>
        /// <returns>loans by the member</returns>
        public IEnumerable<Loan> LoansBySpecificMember(Member member)
        {
            return _loanRepository.GetAllLoansByMemberByObject(member);
        }

        /// <summary>
        /// calls a method in the loan repository to get all loans by a member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>all loans by the member</returns>
        public IEnumerable<Loan> GetAllLoansByMember(int id)
        {
            return _loanRepository.GetAllLoansByMemberById(id);
        }

        protected virtual void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }

    }
}