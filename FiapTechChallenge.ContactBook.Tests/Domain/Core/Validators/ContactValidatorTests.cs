using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Validators;
using FluentValidation.TestHelper;

namespace FiapTechChallenge.ContactBook.Tests.Domain.Core.Validators
{
    public class ContactValidatorTests
    {
        private readonly ContactValidator _validator;

        public ContactValidatorTests()
        {
            _validator = new ContactValidator();
        }

        [Fact]
        public void NameIsRequired()
        {
            var contact = new Contact { Name = null };
            var result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.Name);
        }

        [Fact]
        public void EmailIsRequiredAndValid()
        {
            var contact = new Contact { Email = null };
            var result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.Email);

            contact.Email = "invalidemail";
            result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.Email);

            contact.Email = "valid@example.com";
            result = _validator.TestValidate(contact);
            result.ShouldNotHaveValidationErrorFor(c => c.Email);
        }

        [Fact]
        public void PhoneIsRequiredAndValid()
        {
            var contact = new Contact { Phone = null };
            var result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.Phone);

            contact.Phone = "";
            result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.Phone);

            contact.Phone = "123";
            result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.Phone);

            contact.Phone = "invalidphone";
            result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.Phone);

            contact.Phone = "11987654321";
            result = _validator.TestValidate(contact);
            result.ShouldNotHaveValidationErrorFor(c => c.Phone);
        }

        [Fact]
        public void DDDIdIsRequired()
        {
            var contact = new Contact { DDDId = null };
            var result = _validator.TestValidate(contact);
            result.ShouldHaveValidationErrorFor(c => c.DDDId);

            contact.DDDId = 1;
            result = _validator.TestValidate(contact);
            result.ShouldNotHaveValidationErrorFor(c => c.DDDId);
        }
    }
}

