using FiapTechChallenge.ContactBook.Application.DTOs.Contracts;
using FiapTechChallenge.ContactBook.Domain.Core.Contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public MessageController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] MessageContractDto messageContractDto)
        {
            await _publishEndpoint.Publish(new MessageContract
            {
                Phone = messageContractDto.Phone,
                Message = messageContractDto.Message
            });
            return Accepted("Message sent to queue");
        }
    }
}
