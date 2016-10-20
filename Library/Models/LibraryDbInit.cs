using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            Author alexDumas = new Author() {
                AuthorName = "Alexandre Dumas"
            };

            Book monteCristo = new Book() {
                BookTitle =  "The Count of Monte Cristo",
                BookAuthor = alexDumas
            };

            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
