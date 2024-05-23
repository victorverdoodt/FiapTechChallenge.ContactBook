using System.ComponentModel.DataAnnotations;

namespace FiapTechChallenge.ContactBook.Application.DTOs.Entities
{
    public class UpdateContactDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
