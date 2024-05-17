using FiapTechChallenge.ContactBook.Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FiapTechChallenge.ContactBook.Application.DTOs.Default
{
    public class PaginationDto
    {
        [Range(1, 30)]
        public int Take { get; set; } = 10;

        [Positive]
        public int Page { get; set; } = 1;
    }
}
