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

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Author item)
        {
            _context.Authors.Add(item);
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }

        public void Edit(Author item)
        {
            var query = from a in _context.Authors
                        where a.AuthorId == item.AuthorId
                        select a;

            foreach (Author author in query)
            {
                author.AuthorId = item.AuthorId;
                author.AuthorName = item.AuthorName;
                author.Books = item.Books;

            }

            _context.SaveChanges();
        }

        public Author Find(int id)
        {
            return _context.Authors.Find(id);
        }

        public void Remove(Author item)
        {
            _context.Authors.Remove(item);
        }
    }
}