using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Loan item)
        {
            _context.Loans.Add(item);
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList();
        }

        public void Edit(Loan item)
        {
            var query = from l in _context.Loans
                        where l.LoanId == item.LoanId
                        select l;

            foreach (Loan loan in query)
            {
                loan.LoanId = item.LoanId;
                loan.TimeOfLoan = item.TimeOfLoan;
                loan.DueDate = item.DueDate;
                loan.Member = item.Member;
                loan.TimeOfReturn = item.TimeOfReturn;
                loan.BookCopy = item.BookCopy;

            }

            _context.SaveChanges();
        }

        public Loan Find(int id)
        {
            return _context.Loans.Find(id);
        }

        public void Remove(Loan item)
        {
            _context.Loans.Remove(item);
        }
    }
}