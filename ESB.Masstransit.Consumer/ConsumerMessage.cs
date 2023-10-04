using MassTransit;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESB.Masstransit.Consumer
{
    public class ConsumerMessage : IConsumer<IMessage>
    {
        public Task Consume(ConsumeContext<IMessage> context)
        {
            if(context.Message.isSuccess)
                Console.WriteLine($"Gelen mesaj : {context.Message.text}");
            return Task.CompletedTask;
        }
    }
}
