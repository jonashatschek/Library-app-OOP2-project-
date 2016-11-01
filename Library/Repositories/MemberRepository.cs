using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public void Add(Member item)
        {
            _context.Members.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }

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

        public Member Find(int id)
        {
            return _context.Members.Find(id);
        }

        public void Remove(Member item)
        {
            _context.Members.Remove(item);
        }
    }
}