using AppData.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace AppServices.Infrastructure;
public static class ConfigureServicesExtensions
{
    public static void ConfigureMyServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<AppDbContext>();
    }
}
