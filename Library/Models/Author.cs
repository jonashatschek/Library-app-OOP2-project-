using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    /// <summary>
    /// Author class property declaration
    /// </summary>
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AuthorName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.AuthorName);
        }
    }
}