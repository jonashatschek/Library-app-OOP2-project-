using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Library.Models
{

    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookTitle { get; set; }
        public int BookIsbn { get; set; }
        public string BookDescription { get; set; }
        [Required]
        public virtual Author BookAuthor { get; set; }
        public virtual ICollection<BookCopy> BookCopy { get; set; }


        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.BookId, this.BookTitle);
        }
    }
}