using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    public class BookService : IService
    {
        BookRepository _bookRepository;
        Book _book = new Book();

        public event EventHandler Updated;

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        /// <summary>
        /// calls the All-method in Book repository
        /// </summary>
        /// <returns>a collection of all book type objects in database</returns>
        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public IEnumerable<Book> AllBooksWithAtLeastOneCopy()
        {
            return _bookRepository.AllBooksWithAtLeastOneCopy();
        }

        /// <summary>
        /// calls the Add method in the Book repository sending in a new object
        /// </summary>
        /// <param name="title">book title</param>
        /// <param name="isbn">book ISBN</param>
        /// <param name="description">book description</param>
        /// <param name="author">book author</param>
        public void AddNewBook(string title, string isbn, string description, Author author)
        {
            _book.BookTitle = title;
            _book.BookIsbn = isbn;
            _book.BookDescription = description;
            _book.BookAuthor = author;

            _bookRepository.Add(_book);

            OnUpdated();

        }

        /// <summary>
        /// calls the remove method in book repository
        /// </summary>
        /// <param name="book">book to be removed</param>
        public void RemoveBook(Book book)
        {

            _bookRepository.Remove(book);
            OnUpdated();
        }

        /// <summary>
        /// calls the edit method in book repository
        /// </summary>
        /// <param name="book">book to be edited</param>
        public void EditBook(Book book)
        {
            _bookRepository.Edit(book);
        }

        /// <summary>
        /// gets books by an author 
        /// </summary>
        /// <param name="id">author id</param>
        /// <returns>books written by the author</returns>
        public IEnumerable<Book> GetBookByAuthor(int id)
        {
            return _bookRepository.GetBookByAuthor(id);
        }

        /// <summary>
        /// edits a book
        /// </summary>
        /// <param name="id">book id</param>
        /// <returns>the edited book</returns>
        public Book EditBook(int id)
        {
            return _bookRepository.Find(id);
        }

        protected virtual void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }

    }
}