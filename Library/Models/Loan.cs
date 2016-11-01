using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        [Required]
        public DateTime? TimeOfLoan { get; set; }

        [Required]
        public DateTime? DueDate { get; set; }

        public DateTime? TimeOfReturn { get; set; }

        public virtual BookCopy BookCopy { get; set; }

        public virtual Member Member { get; set; }

        public override string ToString()
        {
            Convert.ToString(DueDate);
                return String.Format("[{0}] -- {1}" + " [Loaned until {3}]", this.BookCopy.BookCopyId, this.BookCopy.Book.BookTitle, this.DueDate.Value);
        }

    }
}