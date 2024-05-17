using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;

namespace FiapTechChallenge.ContactBook.Application.Interfaces
{
    public interface IDDDService : IAsyncService<DDD>
    {
        Task<DDD> GetDDDByCodeAsync(string code);
    }
}
