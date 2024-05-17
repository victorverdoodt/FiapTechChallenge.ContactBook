using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using System.Text.RegularExpressions;

namespace FiapTechChallenge.ContactBook.Domain.Core.Entities
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? DDDId { get; set; }

        public virtual DDD DDDNavigation { get; set; }

        public bool IsValidPhoneNumber()
        {
            var regex = new Regex(@"^\d{10,11}$");
            var normalizedPhone = NormalizePhoneNumber();
            return regex.IsMatch(normalizedPhone);
        }

        public string ExtractDDD()
        {
            var normalizedPhone = NormalizePhoneNumber();
            return normalizedPhone.Substring(0, 2);
        }

        private string NormalizePhoneNumber()
        {
            var normalizedPhone = Regex.Replace(Phone, @"[^\d]", "");
            normalizedPhone = normalizedPhone.TrimStart('0');
            return normalizedPhone;
        }
    }
}
