using Test.Dotnet.Queue.Subscriber.Core.Interfaces;
using Test.Dotnet.Queue.Subscriber.Core.Services;

namespace Test.Dotnet.Queue.Subscriber.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
