using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionService _regionService;
        private readonly IDistributedCache _distributedCache;
        private readonly IConfiguration _configuration;
        public RegionsController(IRegionService regionService, IDistributedCache distributedCache, IConfiguration configuration)
        {
            _regionService = regionService;
            _distributedCache = distributedCache;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegionsAsync()
        {
            var cacheKey = $"GetAll_GetRegionsAsync";
            var cacheData = await _distributedCache.GetStringAsync(cacheKey);
            IRequestResponse<IQueryable<ResponseRegionDto>> entities;
            if (!string.IsNullOrEmpty(cacheData))
            {
                return Ok(JsonSerializer.Deserialize<Response<List<ResponseRegionDto>>>(cacheData));
            }

            entities = await _regionService.FindAsync<ResponseRegionDto>();
            if (entities.Data == null || !entities.Data.Any())
                return NoContent();

            var serializedData = JsonSerializer.Serialize(entities);
            var chacheTime = _configuration.GetValue<int>("CacheTime");
            await _distributedCache.SetStringAsync(cacheKey, serializedData, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(chacheTime)
            });

            return Ok(entities);
        }
    }
}
