using System.Linq.Expressions;

namespace FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {
        Task<TEntity> FindById(params object[] keyValues);

        Task<IRequestResponse<IQueryable<TEntity>>> Find(ISpecification<TEntity> specification = null);
        Task<IQueryable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        Task Add(TEntity entity);

        Task AddRange(IEnumerable<TEntity> entities);

        Task Remove(TEntity entity);

        Task RemoveRange(IEnumerable<TEntity> entities);

        Task Update(TEntity entity);

        Task<bool> Contains(ISpecification<TEntity> specification = null);

        Task<bool> Contains(Expression<Func<TEntity, bool>> predicate);

        Task<int> Count(ISpecification<TEntity> specification = null);

        Task<int> Count(Expression<Func<TEntity, bool>> predicate);
    }
}
