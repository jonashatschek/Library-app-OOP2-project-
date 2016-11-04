using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        /// <summary>
        /// adds an item to database
        /// </summary>
        /// <param name="item">item to add into database</param>
        public void Add(BookCopy item)
        {
            try
            {
                _context.BookCopies.Add(item);
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
        /// gets all BookCopy type items in database
        /// </summary>
        /// <returns>all BookCopy type items currently in database</returns>
        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }

        /// <summary>
        /// Edits an BookCopy type object in database
        /// </summary>
        /// <param name="item">BookCopy object to edit</param>
        public void Edit(BookCopy item)
        {
            var query = from b in _context.BookCopies
                        where b.BookCopyId == item.BookCopyId
                        select b;

            foreach (BookCopy bookCopy in query)
            {
                bookCopy.BookCopyId = item.BookCopyId;
                bookCopy.Book = item.Book;

            }

            _context.SaveChanges();
        }

        /// <summary>
        /// Finds and retrieves an BookCopy object in the database
        /// </summary>
        /// <param name="id">Id of object</param>
        /// <returns>retrieved BookCopy object from database</returns>
        public BookCopy Find(int id)
        {
            return _context.BookCopies.Find(id);
        }

        /// <summary>
        /// Removes an BookCopy object from the database
        /// </summary>
        /// <param name="item">BookCopy object to remove</param>
        public void Remove(BookCopy item)
        {
            _context.BookCopies.Remove(item);

            _context.SaveChanges();
        }

        /// <summary>
        /// Get a selection of BookCopy objects by their book id
        /// </summary>
        /// <param name="id">id number</param>
        /// <returns>a collection of BookCopy objects</returns>
        public IEnumerable<BookCopy> GetBookCopiesByBookId(int id)
        {
            return All().Where(b => b.Book.Id == id);

        }

    }
}