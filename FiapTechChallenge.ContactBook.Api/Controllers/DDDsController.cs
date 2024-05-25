using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDDsController : ControllerBase
    {
        private readonly IDDDService _DDDService;
        public DDDsController(IDDDService dDDService)
        {
            _DDDService = dDDService;
        }
        [HttpGet]
        public async Task<IActionResult> GetDDDsAsync()
        {
            var result = await _DDDService.FindAsync<ResponseDDDDto>();
            return Ok(result);
        }
    }
}
