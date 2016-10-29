using System;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    public class LoanService : IService
    {
        LoanRepository _loanRepository;

        Loan loan = new Loan();

        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public void NewLoan(Loan loan)
        {
            throw new NotImplementedException();
        }

        public void ReturnBookCopy(BookCopy bookCopy)
        {
            throw new NotImplementedException();
        }

        public void LoansBySpecificMember(Member member)
        {
            throw new NotImplementedException();
        }




        public event EventHandler Updated;
    }
}