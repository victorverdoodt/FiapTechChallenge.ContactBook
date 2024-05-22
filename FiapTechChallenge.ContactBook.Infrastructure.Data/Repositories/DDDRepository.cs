using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Repositories;
using FiapTechChallenge.ContactBook.Domain.Repositories;

namespace FiapTechChallenge.ContactBook.Infrastructure.Data.Repositories
{
    public class DDDRepository : AsyncRepository<DDD>, IDDDRepository
    {
        public DDDRepository(IAppDbContext context) : base(context)
        {
        }
    }
}
