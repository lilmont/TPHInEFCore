using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TPHInEFCore.Persistence.Context;

namespace TPHInEFCore.Persistence.Configuration;
public static class PersistenceConfiguration
{
    public static IServiceCollection Configure(
        IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<TphEfCoreDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }
}
