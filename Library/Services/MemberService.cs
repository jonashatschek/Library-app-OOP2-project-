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

        /// <summary>
        /// calls the All-method in Member repository
        /// </summary>
        /// <returns>a collection of all Member type objects in database</returns>
        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }

        /// <summary>
        /// calls the Add method in the member repository
        /// </summary>
        /// <param name="name">name of new member</param>
        /// <param name="id">id of new member</param>
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