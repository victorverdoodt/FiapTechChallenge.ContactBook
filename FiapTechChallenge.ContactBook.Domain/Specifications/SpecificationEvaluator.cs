using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using Microsoft.EntityFrameworkCore;

namespace FiapTechChallenge.ContactBook.Domain.Specifications
{
    public class SpecificationEvaluator<TEntity> where TEntity : class
    {
        public static IRequestResponse<IQueryable<TEntity>> GetQuery<T>(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification) where T : class
        {
            var query = inputQuery;

            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));
            query = specification.IncludeStrings.Aggregate(query, (current, include) => current.Include(include));

            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            if (specification.GroupBy != null)
            {
                query = query.GroupBy(specification.GroupBy).SelectMany(x => x);
            }

            if (specification.IsPagingEnabled)
            {
                var total = query.Count();

                var pagedData = query.Skip(((!(specification.Page > 1)) ? new int?(0) : ((specification.Page - 1) * specification.Take)).Value).Take(specification.Take);

                return new PaginatedResponse<IQueryable<TEntity>>
                {
                    Data = pagedData,
                    CurrentPage = specification.Page,
                    PerPage = specification.Take,
                    Total = total,
                    IsPaginated = true

                };
            }
            else
            {
                return new Response<IQueryable<TEntity>>
                {
                    Data = query,
                    IsPaginated = false
                };
            }
        }
    }
}
