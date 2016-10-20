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

        [Required]
        public DateTime? TimeOfReturn { get; set; }

        public virtual BookCopy BookCopy { get; set; }
        public virtual Member Member { get; set; }

    }
}