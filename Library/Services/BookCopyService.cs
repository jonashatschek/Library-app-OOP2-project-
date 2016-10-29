using System;
using Library.Repositories;

namespace Library.Services
{
    public class BookCopyService : IService
    {
        BookCopyRepository _bookCopyRepository;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        public event EventHandler Updated;
    }
}