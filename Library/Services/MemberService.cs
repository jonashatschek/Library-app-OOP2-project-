using System;
using System.Collections.Generic;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    public class MemberService : IService
    {
        MemberRepository _memberRepository;
        Member member = new Member();
        public event EventHandler Updated;

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }

        public void AddNewMember(string name, string id)
        {
            member.MemberName = name;
            member.PersonalId = id;

            _memberRepository.Add(member);
            OnUpdated();
        }

        protected virtual void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }

    }
}