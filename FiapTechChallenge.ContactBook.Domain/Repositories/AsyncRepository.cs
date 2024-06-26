﻿using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace FiapTechChallenge.ContactBook.Domain.Repositories
{
    public class AsyncRepository<TEntity> : IAsyncRepository<TEntity> where TEntity : class
    {

        protected IAppDbContext _context;

        public AsyncRepository(IAppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<TEntity> FindById(params object[] keyValues) => await _context.Set<TEntity>().FindAsync(keyValues);

        public virtual async Task Add(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task AddRange(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public virtual Task Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public virtual Task Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public virtual Task RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            return _context.SaveChangesAsync();
        }

        public virtual async Task<bool> Contains(ISpecification<TEntity> specification = null)
        {
            return await Count(specification) > 0 ? true : false;
        }

        public virtual async Task<bool> Contains(Expression<Func<TEntity, bool>> predicate)
        {
            return await Count(predicate) > 0 ? true : false;
        }

        public virtual async Task<int> Count(ISpecification<TEntity> specification = null)
        {
            return await ApplySpecification(specification).Data.CountAsync();
        }

        public virtual async Task<int> Count(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).CountAsync();
        }

        public virtual async Task<IRequestResponse<IQueryable<TEntity>>> Find(ISpecification<TEntity> specification = null)
        {
            return ApplySpecification(specification);
        }

        public virtual async Task<IQueryable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public virtual Task<int> CountAll() => _context.Set<TEntity>().CountAsync();

        public virtual Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate)
            => _context.Set<TEntity>().CountAsync(predicate);

        private IRequestResponse<IQueryable<TEntity>> ApplySpecification(ISpecification<TEntity> spec)
        {
            return SpecificationEvaluator<TEntity>.GetQuery<TEntity>(_context.Set<TEntity>().AsQueryable(), spec);
        }
    }
}
