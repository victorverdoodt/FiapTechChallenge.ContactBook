using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using System.Text.Json.Serialization;

namespace FiapTechChallenge.ContactBook.Domain.Core.Models.Default
{
    public class Response<T> : IRequestResponse<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public bool IsPaginated { get; set; }
    }
}
