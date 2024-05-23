using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        public RegionsController()
        {
                
        }

        [HttpGet]
        public async Task<IActionResult> GetRegionsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
