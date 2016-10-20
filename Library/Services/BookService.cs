using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    class BookService : IService
    {
        BookRepository _bookRepository;
        Book _book = new Book();
        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public void AddNewBook(string title, Author author, string description, int isbn)
        {

            _book.BookTitle = title;
            _book.BookAuthor = author;
            _book.BookDescription = description;
            _book.BookIsbn = isbn;

            _bookRepository.Add(_book);
        }

        public void ListAvailableBooks()
        {
            var query = from b in _bookRepository.All()
                where b.BookCopy.Count > 0
                select b;

            foreach (Book b in query)
            {
                //add to listbox when created
            }
        }

        public void ListAllBooksByAuthor(Author authorName, Book bookId)
        {
            var query = from m in _bookRepository.All()
                where m.BookAuthor.Equals(authorName)
                select m;

            foreach (Book book in query)
            {
                //add to listbox when created
            }
        }

        public event EventHandler Updated;
    }
}