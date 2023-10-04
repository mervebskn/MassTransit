

using MassTransit;
using MassTransit.WorkerService.Consumer;

IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
{
    services.AddMassTransit(config =>
    {
        config.AddConsumer<MessageConsumer>();

        config.UsingRabbitMq((context, _config) =>
        {
            _config.Host("amqp://guest:guest@localhost:5672");

            //consumer'�n hangi queue'yi t�keteci�ini yap�land�rd�k..
            _config.ReceiveEndpoint("example-queue", e =>
            {
                e.ConfigureConsumer<MessageConsumer>(context);
            });
        });
    });
}).Build();

host.Run();