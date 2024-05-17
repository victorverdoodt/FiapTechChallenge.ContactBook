using System.Linq.Expressions;

namespace FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default
{
    public interface IAsyncService<TEntity> where TEntity : class
    {
        Task<TEntity> FindByIdAsync(params object[] keyValues);
        Task<TDto> FindByIdAsync<TDto>(int id);
        Task<IRequestResponse<IQueryable<TEntity>>> FindAsync(ISpecification<TEntity> specification = null);
        Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<IRequestResponse<IQueryable<TDto>>> FindAsync<TDto>(ISpecification<TEntity> specification = null);
        Task AddAsync(TEntity entity);
        Task AddAsync<TCreateDto>(TCreateDto entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity entity);
        Task UpdateAsync<TCreateDto>(TCreateDto entity);
        Task<bool> ContainsAsync(ISpecification<TEntity> specification = null);
        Task<bool> ContainsAsync(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAsync(ISpecification<TEntity> specification = null);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
