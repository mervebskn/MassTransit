using Shared;

namespace MassTransit.WorkerService.Consumer
{
    public class MessageConsumer : IConsumer<IMessage>
    {
        public Task Consume(ConsumeContext<IMessage> context)
        {
            Console.WriteLine($"Gelen mesaj : {context.Message.text}");
            return Task.CompletedTask;
        }
    }
}
