using MassTransit;
using Shared;

namespace Masstransit.WorkerService.Publisher
{
    public class MessageService : BackgroundService
    {
        readonly IPublishEndpoint _publishEndpoint;
        public MessageService(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int i = 0;
            while (true)
            {
                ResultMessage message = new()
                {
                    text = $"{++i}. mesaj"
                };
                await _publishEndpoint.Publish(message);
            }
        }
    }
}
