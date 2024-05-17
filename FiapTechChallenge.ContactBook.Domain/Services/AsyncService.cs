using AutoMapper;
using AutoMapper.QueryableExtensions;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace FiapTechChallenge.ContactBook.Domain.Services
{
    public class AsyncService<TEntity> : IAsyncService<TEntity> where TEntity : BaseEntity
    {
        private readonly IAsyncRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public AsyncService(IAsyncRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TEntity> FindByIdAsync(params object[] keyValues) => await _repository.FindById(keyValues);

        public async Task<TDto> FindByIdAsync<TDto>(int id)
        {
            var response = await _repository.Find();
            var projectedQuery = _mapper.ProjectTo<TDto>(response.Data.Where(x => x.Id == id));
            return await projectedQuery.FirstOrDefaultAsync();
        }

        public async Task<IRequestResponse<IQueryable<TEntity>>> FindAsync(ISpecification<TEntity> specification = null) => await _repository.Find(specification);

        public async Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate) => await _repository.Find(predicate);

        public async Task<IRequestResponse<IQueryable<TDto>>> FindAsync<TDto>(ISpecification<TEntity> specification = null)
        {
            var response = await _repository.Find(specification);
            var projectedQuery = response.Data.ProjectTo<TDto>(_mapper.ConfigurationProvider);
            if (response.IsPaginated)
            {
                var paginatedResponse = response as PaginatedResponse<IQueryable<TEntity>>;
                return new PaginatedResponse<IQueryable<TDto>>
                {
                    Data = projectedQuery,
                    IsPaginated = true,
                    CurrentPage = paginatedResponse.CurrentPage,
                    PerPage = paginatedResponse.PerPage,
                    Total = paginatedResponse.Total,
                };
            }

            return new Response<IQueryable<TDto>>
            {
                Data = projectedQuery,
                IsPaginated = false
            };
        }

        public async Task AddAsync(TEntity entity) => await _repository.Add(entity);

        public async Task AddAsync<TCreateDto>(TCreateDto entity)
        {
            var mapped = _mapper.Map<TEntity>(entity);
            await _repository.Add(mapped);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities) => await _repository.AddRange(entities);

        public async Task RemoveAsync(TEntity entity) => await _repository.Remove(entity);

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities) => await _repository.RemoveRange(entities);

        public async Task UpdateAsync(TEntity entity) => await _repository.Update(entity);

        public async Task UpdateAsync<TUpdateDto>(TUpdateDto entity)
        {
            var oldEntity = await _repository.FindById((entity as BaseEntity).Id);
            var mapped = _mapper.Map(entity, oldEntity);
            await _repository.Update(mapped);
        }

        public async Task<bool> ContainsAsync(ISpecification<TEntity> specification = null) => await _repository.Contains(specification);

        public async Task<bool> ContainsAsync(Expression<Func<TEntity, bool>> predicate) => await _repository.Contains(predicate);

        public async Task<int> CountAsync(ISpecification<TEntity> specification = null) => await _repository.Count(specification);

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate) => await _repository.Count(predicate);
    }
}
