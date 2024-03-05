using Kyrios.BunnyStream.Interfaces;

namespace BunnyStream.Net.Handler.Base;

public class BunnyApiBaseRequester: IBunnyRequester
{
    protected string? ApiKey;
    protected string? BaseUrl;

    public BunnyApiBaseRequester(string baseUrl, string? apiKey = null)
    {
        SetBaseUrl(baseUrl);

        if (apiKey is not null)
            SetApiKey(apiKey);

    }
    public virtual string SetBaseUrl(string baseUrl) => BaseUrl = baseUrl;
    public virtual string SetApiKey(string apiKey) => BaseUrl = apiKey;

    protected HttpClient GetHttpClient()
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("AccessKey", ApiKey);
        return httpClient;
    }
}
