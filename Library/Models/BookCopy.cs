using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookCopy
    {
        [Key]
        public int BookCopyId { get; set; }

        [Required]
        public virtual Book Book { get; set; }


    }
}