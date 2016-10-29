using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {
    public class BookRepository : IRepository<Book, int> {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public void Add(Book item)
        {
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Book> All() {
            return _context.Books.ToList();
        }

        public void Edit(Book item)
        {
            var query = from b in _context.Books
                        where b.Id == item.Id
                        select b;

            foreach (Book book in query)
            {
                book.Id = item.Id;
                book.BookAuthor = item.BookAuthor;
                book.BookDescription = item.BookDescription;
                book.BookIsbn = item.BookIsbn;
                book.BookTitle = item.BookTitle;
                book.BookCopy = item.BookCopy;

            }

            _context.SaveChanges();
        }

        public Book Find(int id)
        {
            return _context.Books.Find(id);
        }

        public void Remove(Book item)
        {
            _context.Books.Remove(item);
            _context.SaveChanges();
        }

    }
}