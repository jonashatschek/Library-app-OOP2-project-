using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; }

        [Required]
        public virtual ICollection<Book> Books { get; set; }

    }
}