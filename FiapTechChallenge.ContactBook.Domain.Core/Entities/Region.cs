using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;

namespace FiapTechChallenge.ContactBook.Domain.Core.Entities
{
    public class Region : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<DDD> DDDs { get; set; } = new List<DDD>();
    }
}
