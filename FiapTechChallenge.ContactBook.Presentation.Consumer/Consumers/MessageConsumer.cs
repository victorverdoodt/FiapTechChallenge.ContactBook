using FiapTechChallenge.ContactBook.Domain.Core.Contracts;
using MassTransit;

namespace FiapTechChallenge.ContactBook.Presentation.Consumer.Consumers
{
    public class MessageConsumer : IConsumer<MessageContract>
    {
        private readonly ILogger<MessageConsumer> _logger;
        public MessageConsumer(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<MessageConsumer>();
        }
        public async Task Consume(ConsumeContext<MessageContract> context)
        {
            _logger.LogWarning($"Send message to {context.Message.Phone} : {context.Message.Message}.");
            await Task.CompletedTask;
        }
    }
}
