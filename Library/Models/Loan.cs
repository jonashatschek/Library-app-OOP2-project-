using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Library.Models
{
    /// <summary>
    /// Loan class property declaration
    /// </summary>
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        [Required]
        public DateTime TimeOfLoan { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? TimeOfReturn { get; set; }

        public virtual BookCopy BookCopy { get; set; }

        public virtual Member Member { get; set; }

        public bool isOverdue { get; set; }

        public override string ToString()
        {
            
            return String.Format("[{0}] -- {1}", this.BookCopy.BookCopyId, this.BookCopy.Book.BookTitle);
        }

    }
}