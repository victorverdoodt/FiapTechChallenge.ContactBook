using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using FiapTechChallenge.ContactBook.Presentation.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;


namespace FiapTechChallenge.ContactBook.Tests.Presentation.Controllers
{
    public class DDDsControllerTests
    {
        [Fact]
        public async Task GetDDDsAsync_ReturnsOkWithDDDs()
        {
            // Arrange
            var mockDDDService = new Mock<IDDDService>();
            var ddds = new List<ResponseDDDDto> { new ResponseDDDDto { Id = 1, Code = "11" } };
            var response = new Response<IQueryable<ResponseDDDDto>> { Data = ddds.AsQueryable(), IsPaginated = false };
            mockDDDService.Setup(service => service.FindAsync<ResponseDDDDto>(null))
                          .ReturnsAsync(response);

            var controller = new DDDsController(mockDDDService.Object);

            // Act
            var result = await controller.GetDDDsAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var responseValue = Assert.IsType<Response<IQueryable<ResponseDDDDto>>>(okResult.Value);
            var dddList = responseValue.Data.ToList();
            Assert.Equal(ddds, dddList);
        }

    }
}
