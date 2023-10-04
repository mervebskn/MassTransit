using MassTransit;
using Shared;

string rabbitMQUri = "amqp://guest:guest@localhost:5672";
string queueName = "example-queue";

IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri);
});

ISendEndpoint sendEndpoint= await bus.GetSendEndpoint(new($"{rabbitMQUri}/{queueName}"));
//send ile belirli queue'ya mesaj göderildi

Console.Write("Gönderilecek mesaj :");
string message = Console.ReadLine();

await sendEndpoint.Send<IMessage>(new ResultMessage() { text = message, isSuccess = message != null ? true : false });
Console.Read();

