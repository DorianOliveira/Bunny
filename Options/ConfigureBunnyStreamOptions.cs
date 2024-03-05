using Kyrios.BunnyStream.Model;
using Microsoft.Extensions.Options;

namespace Kyrios.BunnyStream.Options;

public abstract class ConfigureBunnyOptions<T>(IOptions<BunnyOptionsBuilder> optionsBuilder) : IConfigureOptions<T> where T: BunnyHandlerOptions
{
    protected readonly BunnyOptionsBuilder OptionsBuilder = optionsBuilder.Value;

    public void Configure(T options)
    {
        options.StreamLibraryResourceName = OptionsBuilder?.StreamLibraryResourceName ?? "";
        options.DnsBaseResourceName = OptionsBuilder?.DnsBaseResourceName ?? "";
        options.PullZoneResourceName= OptionsBuilder?.PullZoneResourceName ?? "";
        options.PurgeResourceName = OptionsBuilder?.PurgeResourceName ?? "";
        options.StatisticsResourceName = OptionsBuilder?.StatisticsResourceName ?? "";
        options.StorageZoneResourceName= OptionsBuilder?.StorageZoneResourceName ?? "";
        options.CdnStreamCollectionsResourceName = OptionsBuilder?.CdnStreamCollectionsResourceName ?? "";
        options.CdnStreamVideosResourceName = OptionsBuilder?.CdnStreamVideosResourceName ?? "";

        SetMainSettings(options);
    }

    protected abstract void SetMainSettings(BunnyHandlerOptions options);
}

public class ConfigureBunnyApiOptions(IOptions<BunnyOptionsBuilder> optionsBuilder)
    : ConfigureBunnyOptions<BunnyApiHandlerOptions>(optionsBuilder)
{
    protected override void SetMainSettings(BunnyHandlerOptions options)
    {
        options.BaseUrl = OptionsBuilder?.ApiBaseUrl ?? "";
        options.ApiKey = OptionsBuilder?.ApiKey ?? "";
    }
}


public class ConfigureBunnyStreamOptions(IOptions<BunnyOptionsBuilder> optionsBuilder)
    : ConfigureBunnyOptions<BunnyStreamHandlerOptions>(optionsBuilder)
{
    protected override void SetMainSettings(BunnyHandlerOptions options)
    {
        options.BaseUrl = OptionsBuilder?.StreamCdnBaseUrl ?? "";
        options.ApiKey = OptionsBuilder?.StreamLibraryApiKey ?? "";
    }
}

