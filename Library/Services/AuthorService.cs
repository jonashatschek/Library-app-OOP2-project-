using System;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class AuthorService : IService
    {
        AuthorRepository _authorRepository;

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public void newAuthor(Author author)
        {
            //needs some more variables.
            _authorRepository.Add(author);
        }

        public event EventHandler Updated;
    }
}