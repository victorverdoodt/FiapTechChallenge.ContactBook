using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionService _regionService;
        public RegionsController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegionsAsync()
        {
            var result = await _regionService.FindAsync<ResponseRegionDto>();
            return Ok(result);
        }
    }
}
