using AutoMapper;
using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Application.Services;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Repositories;
using FluentValidation;
using FluentValidation.Results;
using Moq;

namespace FiapTechChallenge.ContactBook.Tests.Application.Services
{
    public class ContactServiceTests
    {
        [Fact]
        public async Task AddAsync_ValidContact_AddsContact()
        {
            // Arrange
            var mockRepository = new Mock<IContactRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockValidator = new Mock<IValidator<Contact>>();
            var mockDDDService = new Mock<IDDDService>();

            var contactService = new ContactService(mockRepository.Object, mockMapper.Object, mockValidator.Object, mockDDDService.Object);

            var contactDto = new CreateContactDto { Name = "John Doe", Email = "john.doe@example.com", Phone = "11987654321" };
            var contact = new Contact { Name = "John Doe", Email = "john.doe@example.com", Phone = "11987654321" };

            mockMapper.Setup(mapper => mapper.Map<Contact>(contactDto))
                      .Returns(contact);

            mockDDDService.Setup(service => service.GetDDDByCodeAsync("11"))
                          .ReturnsAsync(new DDD { Id = 1 });

            mockValidator.Setup(validator => validator.Validate(contact))
                         .Returns(new ValidationResult());

            // Act
            await contactService.AddAsync(contactDto);

            // Assert
            mockRepository.Verify(repository => repository.Add(contact), Times.Once());
        }

        [Fact]
        public async Task UpdateAsync_ValidContact_UpdatesContact()
        {
            // Arrange
            var mockRepository = new Mock<IContactRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockValidator = new Mock<IValidator<Contact>>();
            var mockDDDService = new Mock<IDDDService>();

            var contactService = new ContactService(mockRepository.Object, mockMapper.Object, mockValidator.Object, mockDDDService.Object);

            var contactDto = new UpdateContactDto { Id = 1, Name = "John Doe", Email = "john.doe@example.com", Phone = "11987654321" };
            var contact = new Contact { Id = 1, Name = "John Doe", Email = "john.doe@example.com", Phone = "11987654321" };

            mockMapper.Setup(mapper => mapper.Map<Contact>(contactDto))
                      .Returns(contact);

            mockDDDService.Setup(service => service.GetDDDByCodeAsync("11"))
                          .ReturnsAsync(new DDD { Id = 1 });

            mockValidator.Setup(validator => validator.Validate(contact))
                         .Returns(new ValidationResult());

            // Act
            await contactService.UpdateAsync(contactDto);

            // Assert
            mockRepository.Verify(repository => repository.Update(contact), Times.Once());
        }
    }

}
