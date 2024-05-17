using FiapTechChallenge.ContactBook.Application.DTOs.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using FiapTechChallenge.ContactBook.Domain.Specifications;
using System.Linq.Expressions;

namespace FiapTechChallenge.ContactBook.Application.Specification
{
    public class PagedSpecification<TEntity> : BaseSpecification<TEntity> where TEntity : BaseEntity
    {
        public PagedSpecification(PaginationDto dto, Expression<Func<TEntity, bool>> criteria = null) : base(criteria)
        {
            ApplyPaging(dto.Page, dto.Take);
            ApplyOrderBy(x => x.Id);
        }
    }
}
