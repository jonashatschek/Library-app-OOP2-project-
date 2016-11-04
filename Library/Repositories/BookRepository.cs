using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Library.Models;

namespace Library.Repositories {
    public class BookRepository : IRepository<Book, int> {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        /// <summary>
        /// adds an item to database
        /// </summary>
        /// <param name="item">item to add into database</param>
        public void Add(Book item)
        {
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        /// <summary>
        /// gets all Book type items in database
        /// </summary>
        /// <returns>all Book type items currently in database</returns>
        public IEnumerable<Book> All() {
            return _context.Books.ToList();
        }

        /// <summary>
        /// Edits an Book type object in database
        /// </summary>
        /// <param name="item">Book object to edit</param>
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

        /// <summary>
        /// Finds and retrieves an Book object in the database
        /// </summary>
        /// <param name="id">Id of object</param>
        /// <returns>retrieved Book object from database</returns>
        public Book Find(int id)
        {
            return _context.Books.Find(id);
        }

        /// <summary>
        /// Removes an Book object from the database
        /// </summary>
        /// <param name="item">Book object to remove</param>
        public void Remove(Book item)
        {
            try
            {
                _context.Books.Remove(item);
                _context.SaveChanges();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("You have select an item to remove first");
            }
        }

        /// <summary>
        /// gets all the books with atleast one copy from the database
        /// </summary>
        /// <returns>all the books with > 0 copies</returns>
        public IEnumerable<Book> AllBooksWithAtLeastOneCopy()
        {
            return All().Where(b => b.BookCopy.Count > 0);
        }

        /// <summary>
        /// Gets all the books by an author
        /// </summary>
        /// <param name="id">author id number</param>
        /// <returns>All the authors books</returns>
        public IEnumerable<Book> GetBookByAuthor(int id)
        {
            return All().Where(b => b.BookAuthor.Id == id);
        }



    }
}