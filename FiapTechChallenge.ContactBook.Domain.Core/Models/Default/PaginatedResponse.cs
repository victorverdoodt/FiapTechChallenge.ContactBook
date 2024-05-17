using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using System.Text.Json.Serialization;

namespace FiapTechChallenge.ContactBook.Domain.Core.Models.Default
{
    public class PaginatedResponse<T> : IRequestResponse<T>
    {
        public T Data { get; set; }

        public int CurrentPage { get; set; }

        public int PerPage { get; set; }

        public int Total { get; set; }

        public int LastPage => GetTotalPage();

        [JsonIgnore]
        public bool IsPaginated { get; set; }

        private int GetTotalPage()
        {
            if (PerPage <= 0)
            {
                return 1;
            }

            return Convert.ToInt32(Math.Ceiling(Total / (double)PerPage));
        }
    }
}
