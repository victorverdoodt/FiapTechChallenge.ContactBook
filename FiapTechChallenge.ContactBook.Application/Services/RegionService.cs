using AutoMapper;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Repositories;
using FiapTechChallenge.ContactBook.Domain.Services;

namespace FiapTechChallenge.ContactBook.Application.Services
{
    public class RegionService : AsyncService<Region>, IRegionService
    {
        public RegionService(IRegionRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
