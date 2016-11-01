using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
            try
            {
                _context.Loans.Add(item);

                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }
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