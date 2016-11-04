using System;
using System.Collections.Generic;
using System.Linq;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    public class BookCopyService : IService
    {
        LoanRepository _loanRepository;
        BookCopyRepository _bookCopyRepository;
        BookCopy _bookCopy = new BookCopy();

        public event EventHandler Updated;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
            _loanRepository = repoFactory.GetLoanRepository();
        }

        /// <summary>
        /// calls the All-method in BookCopy repository
        /// </summary>
        /// <returns>a collection of all bookcopy type objects in database</returns>
        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public IEnumerable<BookCopy> GetBookCopiesByBook(Book book)
        {
            return All().Where(b => b.Book.Id == book.Id);
        }

        public IEnumerable<BookCopy> GetBookCopiesByBookId(int id)
        {
            return All().Where(b => b.Book.Id == id);

        }

        /// <summary>
        /// calls the Add method in the BookCopy repository sending in a new object
        /// </summary>
        /// <param name="book">book to copy</param>
        public void AddNewBookCopy(Book book)
        {
            _bookCopy.Book = book;
            _bookCopyRepository.Add(_bookCopy);

            OnUpdated();
        }

        /// <summary>
        /// gets all book copies currently not on loan
        /// </summary>
        /// <returns>all book copies currently not on loan</returns>
        public IEnumerable<BookCopy> AllBookCopiesNotOnLoan()
        {
            IEnumerable<BookCopy> copiesNotReturned = _loanRepository.All().Where(l => l.TimeOfReturn == null).Select(x => x.BookCopy);

            return All().Except(copiesNotReturned);
        }

        /// <summary>
        /// get all book copies of a specifik book not on loan
        /// </summary>
        /// <param name="book"></param>
        /// <returns>all book copies of a specific book not on loan</returns>
        public IEnumerable<BookCopy> AllCopiesOfSpecificBookNotOnLoan(Book book)
        {
            return AllBookCopiesNotOnLoan().Where(b => b.Book.Id == book.Id);
        }

        /// <summary>
        /// removes a book copy
        /// </summary>
        /// <param name="id">id of bookcopy to be removed</param>
        public void RemoveBookCopy(int id)
        {
            BookCopy bookCopy = _bookCopyRepository.Find(id);
            _bookCopyRepository.Remove(bookCopy);

            OnUpdated();
        }

        protected virtual void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }

    }
}