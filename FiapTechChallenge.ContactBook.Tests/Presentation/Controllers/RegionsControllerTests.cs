using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using FiapTechChallenge.ContactBook.Presentation.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FiapTechChallenge.ContactBook.Tests.Presentation.Controllers
{
    public class RegionsControllerTests
    {
        [Fact]
        public async Task GetRegionsAsync_ReturnsOkWithRegions()
        {
            // Arrange
            var mockRegionService = new Mock<IRegionService>();
            var regions = new List<ResponseRegionDto> { new ResponseRegionDto { Id = 1, Name = "SP" } };
            var response = new Response<IQueryable<ResponseRegionDto>> { Data = regions.AsQueryable(), IsPaginated = false };
            mockRegionService.Setup(service => service.FindAsync<ResponseRegionDto>(null))
                             .ReturnsAsync(response);

            var controller = new RegionsController(mockRegionService.Object);

            // Act
            var result = await controller.GetRegionsAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var responseValue = Assert.IsType<Response<IQueryable<ResponseRegionDto>>>(okResult.Value);
            var regionList = responseValue.Data.ToList();
            Assert.Equal(regions, regionList);
        }
    }
}
