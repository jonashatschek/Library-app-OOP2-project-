using System;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class MemberService : IService
    {
        MemberRepository _memberRepository;

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public void NewMember(Member member)
        {
            _memberRepository.Add(member);
        }

        public event EventHandler Updated;
    }
}