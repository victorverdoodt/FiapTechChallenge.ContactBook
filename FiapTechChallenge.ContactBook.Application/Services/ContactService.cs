using AutoMapper;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Services;

namespace FiapTechChallenge.ContactBook.Application.Services
{
    public class ContactService : AsyncService<Contact>, IContactService
    {
        public ContactService(IAsyncRepository<Contact> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
