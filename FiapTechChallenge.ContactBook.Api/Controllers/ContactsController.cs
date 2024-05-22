using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Application.Specification;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts([FromQuery] FindContactsByRegionDTO dto) 
        {
            IRequestResponse<IQueryable<ResponseContactDto>> entities;
            entities = await _contactService.FindAsync<ResponseContactDto>(new FindContactsByRegion(dto, dto.RegionId));

            if(entities.Data is null)
                return NoContent();

            var resolveEntities = await entities.Data.ToListAsync();
            entities.Data = resolveEntities.AsQueryable();
            return Ok(entities);
        }

        [HttpPost]
        public async Task<IActionResult> PostContact([FromBody] CreateContactDto contact)
        {
            await _contactService.AddAsync(contact);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact([FromBody] UpdateContactDto contact)
        {
            await _contactService.UpdateAsync(contact);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact([FromRoute] int id)
        {
            var entity = await _contactService.FindByIdAsync(id);
            if(entity is null)
                return NotFound();

            await _contactService.RemoveAsync(entity);
            return NoContent();
        }
    }
}
