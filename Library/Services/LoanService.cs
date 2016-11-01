using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddNewLoan(Member member, BookCopy bookCopy)
        {
            _loan.Member = member;
            _loan.BookCopy = bookCopy;
            _loan.DueDate = DateTime.Today.AddDays(15);
            _loan.TimeOfLoan = DateTime.Now;
            _loan.TimeOfReturn = null;

            _loanRepository.Add(_loan);

            OnUpdated();
        }

        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

        public IEnumerable<BookCopy> GetAvailableBookCopiesByBook()
        {

            var result = from b in _loanRepository.All()
                where b.TimeOfReturn == null
                select b.BookCopy;

            return result.ToList();

        }

        public void ReturnBookCopy(BookCopy bookCopy)
        {
            throw new NotImplementedException();
        }

        public void LoansBySpecificMember(Member member)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }

    }
}