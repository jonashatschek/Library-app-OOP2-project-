using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Library.Models;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        /// <summary>
        /// adds an item to database
        /// </summary>
        /// <param name="item">item to add into database</param>
        public void Add(Member item)
        {
            try
            {
                _context.Members.Add(item);
                _context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Input cannot be left blank");
            }
        }

        /// <summary>
        /// gets all member type items in database
        /// </summary>
        /// <returns>all Member-type items currently in database</returns>
        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }

        /// <summary>
        /// Edits an Member type object in database
        /// </summary>
        /// <param name="item">Member object to edit</param>
        public void Edit(Member item)
        {
            var query = from m in _context.Members
                        where m.PersonalId == item.PersonalId
                        select m;

            foreach (Member member in query)
            {
                member.MemberName = item.MemberName;
                member.PersonalId = item.PersonalId;
                member.Loan = item.Loan;
            }

            _context.SaveChanges();
        }

        /// <summary>
        /// Finds and retrieves an Member object in the database
        /// </summary>
        /// <param name="id">Id of object</param>
        /// <returns>retrieved Member object from database</returns>
        public Member Find(int id)
        {
            return _context.Members.Find(id);
        }

        /// <summary>
        /// Removes an Member object from the database
        /// </summary>
        /// <param name="item">Member object to remove</param>
        public void Remove(Member item)
        {
            _context.Members.Remove(item);
        }
    }
}