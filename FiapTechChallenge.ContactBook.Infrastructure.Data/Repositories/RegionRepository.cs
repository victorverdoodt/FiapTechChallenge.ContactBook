using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Repositories;
using FiapTechChallenge.ContactBook.Domain.Repositories;


namespace FiapTechChallenge.ContactBook.Infrastructure.Data.Repositories
{
    public class RegionRepository : AsyncRepository<Region>, IRegionRepository
    {
        public RegionRepository(IAppDbContext context) : base(context)
        {
        }
    }
}
