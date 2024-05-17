using FiapTechChallenge.ContactBook.Application.DTOs.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;

namespace FiapTechChallenge.ContactBook.Application.Specification
{
    public class FindContactsByRegion : PagedSpecification<Contact>
    {
        public FindContactsByRegion(PaginationDto dto, int regionId) : base(dto, x => x.DDDNavigation.RegionNavigation.Id == regionId)
        {
        }
    }
}
