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
        Book _book = new Book();
        BookCopy _bookCopy = new BookCopy();
        public event EventHandler Updated;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public IEnumerable<BookCopy> GetBookCopiesByBookId(int id)
        {
            return All().Where(b => b.Book.Id == id);

        }

        public void AddNewBookCopy(Book book)
        {
            _bookCopy.Book = book;
            _bookCopyRepository.Add(_bookCopy);

            OnUpdated();
        }

        public IEnumerable<BookCopy> CopiesNotOnLoan()
        {
            var copiesNotReturned = _loanRepository.All().Where(l => l.TimeOfReturn == null).Select(x => x.BookCopy);

            return All().Except(copiesNotReturned);
        }

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