using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    public class AuthorService : IService
    {
        AuthorRepository _authorRepository;
        Author _author = new Author();
        public event EventHandler Updated;

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }

        public void AddNewAuthor(string name)
        {
            //needs some more variables.
            _author.AuthorName = name;
            _authorRepository.Add(_author);

            OnUpdated();
        }

        protected virtual void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }

    }
}