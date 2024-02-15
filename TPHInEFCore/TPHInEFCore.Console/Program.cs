using Microsoft.Extensions.Hosting;
using TPHInEFCore.Persistence.Configuration;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        PersistenceConfiguration.Configure(services, context.Configuration);
    })
    .Build();

host.Run();