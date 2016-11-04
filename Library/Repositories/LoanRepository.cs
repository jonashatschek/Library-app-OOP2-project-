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

        /// <summary>
        /// adds an item to database
        /// </summary>
        /// <param name="item">item to add into database</param>
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

        /// <summary>
        /// gets all Loan type items in database
        /// </summary>
        /// <returns>all Loan type items currently in database</returns>
        public IEnumerable<Loan> All()
        {
            return _context.Loans;
        }

        /// <summary>
        /// Edits an Loan type object in database
        /// </summary>
        /// <param name="item">Loan object to edit</param>
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

        /// <summary>
        /// Finds and retrieves an Loan object in the database
        /// </summary>
        /// <param name="id">Id of object</param>
        /// <returns>retrieved Loan object from database</returns>
        public Loan Find(int id)
        {
            return _context.Loans.Find(id);
        }

        /// <summary>
        /// Removes an Loan object from the database
        /// </summary>
        /// <param name="item">Loan object to remove</param>
        public void Remove(Loan item)
        {
            _context.Loans.Remove(item);
        }

        /// <summary>
        /// gets all the loans by a specific member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>all loans by member</returns>
        public IEnumerable<Loan> GetAllLoansByMemberById(int id)
        {
            return All().Where(l => l.Member.MemberId == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public IEnumerable<Loan> GetAllLoansByMemberByObject(Member member)
        {
            return All().Where(l => member.MemberId == l.Member.MemberId);
        }
    }
}