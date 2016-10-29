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
        public int Id { get; set; }
        [Required]
        public string BookTitle { get; set; }
        public string BookIsbn { get; set; } //TODO: Format this so it writes in different format, e.g. xxxx-xxxx-xxxx-xxxx
        public string BookDescription { get; set; }
        [Required]
        public virtual Author BookAuthor { get; set; }
        public virtual ICollection<BookCopy> BookCopy { get; set; }


        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.BookTitle);
        }
    }
}