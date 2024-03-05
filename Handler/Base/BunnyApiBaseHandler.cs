using BunnyStream.Net.Handler.Base;
namespace Kyrios.BunnyStream.Handler;

public class BunnyApiHandler(string baseUrl, string resource, string? apiKey = null) : BunnyApiBaseRequester(baseUrl, apiKey)
{
    protected string Resource { get; set; } = resource;
    protected virtual string GetRequestUrl() => $"{BaseUrl}/{Resource}";
}