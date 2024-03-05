using Kyrios.BunnyStream.Handler;
using Kyrios.BunnyStream.Interfaces;
using Kyrios.BunnyStream.Model;
using Kyrios.BunnyStream.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Kyrios.BunnyStream.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBunnyStreamServices(this IServiceCollection services, Action<BunnyOptionsBuilder>? options = null)
    {
        services.AddTransient<IConfigureOptions<BunnyStreamHandlerOptions>, ConfigureBunnyStreamOptions>();
        services.AddTransient<IConfigureOptions<BunnyApiHandlerOptions>, ConfigureBunnyApiOptions>();


        services.AddTransient<IBunnyStreamVideoHandler, BunnyStreamVideoHandler>();
        services.AddTransient<IBunnyStreamLibraryHandler, BunnyStreamLibraryHandler>();
        services.AddTransient<IBunnyStreamCollectionsHandler, BunnyStreamCollectionsHandler>();

        services.AddTransient(x => x.GetRequiredService<IOptions<BunnyStreamHandlerOptions>>().Value);
        services.AddTransient(x => x.GetRequiredService<IOptions<BunnyApiHandlerOptions>>().Value);

        if (options != null)
            services.Configure(options);

        return services;
    }
}
