using AutoMapper;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Repositories;
using FiapTechChallenge.ContactBook.Domain.Services;
using FluentValidation;


namespace FiapTechChallenge.ContactBook.Application.Services
{
    public class ContactService : AsyncService<Contact>, IContactService
    {
        private readonly IValidator<Contact> _validator;
        private readonly IDDDService _dddService;
        public ContactService(IContactRepository repository, IMapper mapper, IValidator<Contact> validator, IDDDService dddService) : base(repository, mapper)
        {
            _validator = validator;
            _dddService = dddService;
        }

        public override async Task AddAsync(Contact entity)
        {
            var ddd = entity.ExtractDDD();
            var dddId = await _dddService.GetDDDByCodeAsync(ddd);
            if (dddId is null)
            {
                throw new ValidationException("Invalid DDD code.");
            }

            entity.DDDId = dddId.Id;

            var validationResult = _validator.Validate(entity);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            await base.AddAsync(entity);
        }
    }
}
