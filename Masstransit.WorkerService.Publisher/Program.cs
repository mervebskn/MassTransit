

using Masstransit.WorkerService.Publisher;
using MassTransit;

IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
{
    services.AddMassTransit(config =>
    {
        config.UsingRabbitMq((context, _config) =>
        {
            _config.Host("amqp://guest:guest@localhost:5672");
        });
    });

    services.AddHostedService<MessageService>(provider =>
    {
        using IServiceScope scope = provider.CreateScope();
        IPublishEndpoint publishEndpoint = scope.ServiceProvider.GetService<IPublishEndpoint>();
        return new(publishEndpoint);
    });

}).Build();

host.Run();

