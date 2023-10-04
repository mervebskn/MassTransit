using ESB.Masstransit.Consumer;
using MassTransit;
using Shared;

string rabbitMQUri = "amqp://guest:guest@localhost:5672";
string queueName = "example-queue";

//config işlemleri..
IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri);
    factory.ReceiveEndpoint(queueName, endpoint =>
    {
        endpoint.Consumer<ConsumerMessage>();
    });
});
await bus.StartAsync();

Console.Read();