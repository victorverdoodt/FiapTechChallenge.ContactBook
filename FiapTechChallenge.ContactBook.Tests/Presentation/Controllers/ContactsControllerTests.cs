using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Application.Specification;
using FiapTechChallenge.ContactBook.Presentation.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;

namespace FiapTechChallenge.ContactBook.Tests.Presentation.Controllers
{
    public class ContactsControllerTests
    {
        [Fact]
        public async Task GetContacts_ReturnsNoContent_WhenNoContactsFound()
        {
            // Arrange
            var mockContactService = new Mock<IContactService>();
            mockContactService.Setup(service => service.FindAsync<ResponseContactDto>(It.IsAny<FindContactsByRegion>()))
                              .ReturnsAsync(new PaginatedResponse<IQueryable<ResponseContactDto>>());

            var controller = new ContactsController(mockContactService.Object);

            // Act
            var result = await controller.GetContacts(new FindContactsByRegionDTO());

            // Assert
            var okResult = Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task PostContact_ReturnsCreated()
        {
            // Arrange
            var mockContactService = new Mock<IContactService>();
            var controller = new ContactsController(mockContactService.Object);

            // Act
            var result = await controller.PostContact(new CreateContactDto());

            // Assert
            Assert.IsType<CreatedResult>(result);
        }

        [Fact]
        public async Task UpdateContact_ReturnsNoContent()
        {
            // Arrange
            var mockContactService = new Mock<IContactService>();
            var controller = new ContactsController(mockContactService.Object);

            // Act
            var result = await controller.UpdateContact(new UpdateContactDto());

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task DeleteContact_ReturnsNotFound_WhenContactNotFound()
        {
            // Arrange
            var mockContactService = new Mock<IContactService>();
            mockContactService.Setup(service => service.FindByIdAsync(It.IsAny<int>()))
                              .ReturnsAsync((Contact)null);

            var controller = new ContactsController(mockContactService.Object);

            // Act
            var result = await controller.DeleteContact(1);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task DeleteContact_ReturnsNoContent_WhenContactDeleted()
        {
            // Arrange
            var mockContactService = new Mock<IContactService>();
            mockContactService.Setup(service => service.FindByIdAsync(It.IsAny<int>()))
                              .ReturnsAsync(new Contact());

            var controller = new ContactsController(mockContactService.Object);

            // Act
            var result = await controller.DeleteContact(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }
}
