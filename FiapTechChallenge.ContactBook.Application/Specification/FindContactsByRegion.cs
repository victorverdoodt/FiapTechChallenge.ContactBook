using FiapTechChallenge.ContactBook.Application.DTOs.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;

namespace FiapTechChallenge.ContactBook.Application.Specification
{
    public class FindContactsByRegion : PagedSpecification<Contact>
    {
        public FindContactsByRegion(PaginationDto dto, int? regionId, int? dddId) : base(dto, x => ( (regionId != null ? x.DDDNavigation.RegionNavigation.Id == regionId : x.DDDNavigation.RegionNavigation.Id != null) && (dddId != null ?  x.DDDId == dddId : x.DDDId != null)))
        {
            AddInclude(x => x.DDDNavigation);
            AddInclude(x => x.DDDNavigation.RegionNavigation);
        }
    }
}
