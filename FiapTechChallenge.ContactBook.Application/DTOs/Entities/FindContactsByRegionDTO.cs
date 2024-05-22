using FiapTechChallenge.ContactBook.Application.DTOs.Default;

namespace FiapTechChallenge.ContactBook.Application.DTOs.Entities
{
    public class FindContactsByRegionDTO : PaginationDto
    {
        public int? RegionId { get; set; } = null;
    }
}
