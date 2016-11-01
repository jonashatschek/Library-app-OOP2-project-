using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        public string PersonalId { get; set; }

        [Required]
        public string MemberName { get; set; }

        public virtual ICollection<Loan> Loan { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.MemberId, this.MemberName);
        }
    }
}