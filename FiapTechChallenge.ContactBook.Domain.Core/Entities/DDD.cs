using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;

namespace FiapTechChallenge.ContactBook.Domain.Core.Entities
{
    public class DDD : BaseEntity
    {
        public string Code { get; set; }
        public Int64 RegionId { get; set; }

        public virtual Region RegionNavigation { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
