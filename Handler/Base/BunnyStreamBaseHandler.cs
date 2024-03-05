
namespace BunnyStream.Net.Handler.Base;

public class BunnyStreamBaseHandler(string baseUrl, string resource, string? apiKey = null) : BunnyApiBaseRequester(baseUrl, apiKey)
{
    protected string Resource { get; set; } = resource;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="libraryId">Library Id</param>
    /// <param name="endpoint">The endpoint that follows Resource. 
    /// For instance: https://video.bunnycdn.com/library/[libraryid]/videos/[endpoint]/</param>
    /// <returns></returns>
    protected virtual string BuildRequestUrl(string libraryId, string? endpoint = null)
    {

        var requestUrl = $"{BaseUrl}/{libraryId}/{Resource}";

        if (endpoint is not null)
            requestUrl = $"{requestUrl}/endpoint";

        return requestUrl;
    }
}