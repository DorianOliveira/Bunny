using BunnyStream.Net.Enums;

namespace Kyrios.BunnyStream.Model;

public class BunnyResources
{
    public string StreamLibraryResourceName { get; set; } = "videoLibrary";
    public string DnsBaseResourceName { get; set; } = "dnszone";
    public string PullZoneResourceName { get; set; } = "pullzone";
    public string PurgeResourceName { get; set; } = "purge";
    public string StatisticsResourceName { get; set; } = "statistics";
    public string StorageZoneResourceName { get; set; } = "storagezone";
    public string CdnStreamVideosResourceName { get; set; } = "videos";
    public string CdnStreamCollectionsResourceName { get; set; } = "collections";
}

public class BunnyOptions: BunnyResources
{

    /// <summary>
    /// General account settings API
    /// Use this if you want to use just one Bunny account
    /// </summary>
    public string? ApiKey { get; set; }
    /// <summary>
    /// Stream Library API Key (optional)
    /// Use this if you want to use just one Stream Library
    /// </summary>
    public string? StreamLibraryApiKey { get; set; }

    /// <summary>
    /// Account-based base url 
    ///
    /// </summary>
    public string ApiBaseUrl { get; set; } = "https://api.bunny.net/";

    /// <summary>
    /// Stream library base url
    /// </summary>
    public string StreamCdnBaseUrl { get; set; } = "https://video.bunnycdn.com/library";

    /// <summary>
    /// Storage base url
    /// </summary>
    public string StorageBaseUrl { get; set; } = "https://storage.bunnycdn.com";
}

public class BunnyOptionsBuilder: BunnyOptions
{
}

public class BunnyHandlerOptions : BunnyResources
{
    public string BaseUrl { get; set; } = "";
    public string ApiKey { get; set; } = "";
}

public class BunnyApiHandlerOptions : BunnyHandlerOptions
{

}

public class BunnyStreamHandlerOptions : BunnyHandlerOptions
{

}
