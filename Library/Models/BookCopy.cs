using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookCopy
    {
        [Key]
        public int BookCopyId { get; set; }

        [Required]
        public virtual Book Book { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.BookCopyId, this.Book.BookTitle);
        }
    }
}