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

            Member sampleMember = new Member()
            {
                MemberName = "SampleMafk",
                PersonalId = "8905091129"
            };

            Author jh = new Author()
            {
                AuthorName = "Jonas Hatschek"
            };

            Book jhBook = new Book()
            {
                BookTitle = "Hello",
                BookAuthor = jh
            };

            BookCopy sampleBc = new BookCopy()
            {
                Book = jhBook
            };

            Author alexDumas = new Author() {
                AuthorName = "Alexandre Dumas"
            };

            Book monteCristo = new Book() {
                BookTitle =  "The Count of Monte Cristo",
                BookAuthor = alexDumas
            };

            Loan testLoan = new Loan()
            {
                TimeOfLoan = new DateTime(2016, 04, 1),
                DueDate = new DateTime(2016, 04, 15),
                TimeOfReturn = new DateTime(2016, 04, 18),
                BookCopy = sampleBc,
                Member = sampleMember,
                isOverdue = true
            };

            // Add the book to the DbSet of books.
            context.Books.Add(jhBook);
            context.Books.Add(monteCristo);
            context.BookCopies.Add(sampleBc);
            context.Members.Add(sampleMember);
            context.Loans.Add(testLoan);

            // Persist changes to the database
            context.SaveChanges();

        }
    }
}
