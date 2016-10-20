using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(BookCopy item)
        {
            _context.BookCopies.Add(item);
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }

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

        public BookCopy Find(int id)
        {
            return _context.BookCopies.Find(id);
        }

        public void Remove(BookCopy item)
        {
            _context.BookCopies.Remove(item);
        }
    }
}