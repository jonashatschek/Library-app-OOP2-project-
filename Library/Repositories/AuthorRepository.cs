using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;

        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="ctx">connects the repository with the database</param>
        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        /// <summary>
        /// adds an item to database
        /// </summary>
        /// <param name="item">item to add into database</param>
        public void Add(Author item)
        {
            _context.Authors.Add(item);
            _context.SaveChanges();
        }

        /// <summary>
        /// gets all Author type items in database
        /// </summary>
        /// <returns>all Author type items currently in database</returns>
        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }

        /// <summary>
        /// Edits an author type object in database
        /// </summary>
        /// <param name="item">Author object to edit</param>
        public void Edit(Author item)
        {
            var query = from a in _context.Authors
                        where a.Id == item.Id
                        select a;

            foreach (Author author in query)
            {
                author.Id = item.Id;
                author.AuthorName = item.AuthorName;
                author.Books = item.Books;

            }

            _context.SaveChanges();
        }

        /// <summary>
        /// Finds and retrieves an Author object in the database
        /// </summary>
        /// <param name="id">Id of object</param>
        /// <returns>retrieved Author object from database</returns>
        public Author Find(int id)
        {
            return _context.Authors.Find(id);
        }

        /// <summary>
        /// Removes an Author object from the database
        /// </summary>
        /// <param name="item">Author object to remove</param>
        public void Remove(Author item)
        {
            _context.Authors.Remove(item);
        }
    }
}