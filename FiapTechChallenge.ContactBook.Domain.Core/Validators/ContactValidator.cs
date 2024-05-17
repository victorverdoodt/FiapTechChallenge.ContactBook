using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FluentValidation;

namespace FiapTechChallenge.ContactBook.Domain.Core.Validators
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(contact => contact.Name)
                .NotEmpty()
                    .WithMessage("Name is required.");

            RuleFor(contact => contact.Email)
                .NotEmpty()
                    .WithMessage("Email is required.")
                .EmailAddress()
                    .WithMessage("Email is not valid.");

            RuleFor(contact => contact.Phone)
                .NotEmpty()
                    .WithMessage("Phone is required.")
                .Must((contact, phone) => contact.IsValidPhoneNumber())
                    .WithMessage("Phone is not valid.");

            RuleFor(contact => contact.DDDId)
                .NotNull()
                .WithMessage("DDDId is required");
        }
    }
}
