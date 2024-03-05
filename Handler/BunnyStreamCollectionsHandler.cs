using BunnyStream.Net.Handler.Base;
using BunnyStream.Net.Model.Response;
using Kyrios.BunnyStream.Interfaces;
using Kyrios.BunnyStream.Model;
using Kyrios.BunnyStream.Model.Request;
using Kyrios.BunnyStream.Model.Response;
using Kyrios.Helpers;
using System.Net;

namespace Kyrios.BunnyStream.Handler;
public class BunnyStreamCollectionsHandler(BunnyStreamHandlerOptions options)
    : BunnyStreamBaseHandler(options.BaseUrl, options.StreamLibraryResourceName, options.ApiKey), IBunnyStreamCollectionsHandler
{

    public async Task<BunnyStreamCollectionResponse?> CreateCollectionAsync(string libraryId, string name)
    {
        var url = BuildRequestUrl(libraryId);
        using var httpClient = GetHttpClient();

        var request = new BunnyCreateCollectionRequest(name);

        var response = await httpClient.PostAsync(url, request.ToStringContent());

        if (response.StatusCode == HttpStatusCode.OK)
        {
            var data = await response.Content.ReadAsStringAsync();
            return RequestHelper.GetObjectFromRoot<BunnyStreamCollectionResponse>(data);
        }

        return null;
    }

    public async Task<BunnyResponse?> UpdateCollectionAsync(string libraryId, Guid collectionId, string name)
    {
        var url = BuildRequestUrl(libraryId, collectionId.ToString());
        using var httpClient = GetHttpClient();

        var request = new BunnyUpdateCollectionRequest(name);

        var response = await httpClient.PostAsync(url, request.ToStringContent());

        if (response.StatusCode == HttpStatusCode.OK)
        {
            var data = await response.Content.ReadAsStringAsync();
            return RequestHelper.GetObjectFromRoot<BunnyResponse>(data);
        }

        return null;
    }


    public async Task DeleteCollectionAsync(string libraryId, Guid collectionId)
    {
        var url = BuildRequestUrl(libraryId, collectionId.ToString());
        using var httpClient = GetHttpClient();
        var response = await httpClient.DeleteAsync(url);
    }

    public async Task<ICollection<BunnyStreamCollectionResponse>?> GetCollectionListAsync(string libraryId)
    {
        var url = BuildRequestUrl(libraryId);
        using var httpClient = GetHttpClient();
        var response = await httpClient.GetAsync(url);

        if (response.StatusCode == HttpStatusCode.OK)
        {
            var data = await response.Content.ReadAsStringAsync();
            return RequestHelper.GetObject<ICollection<BunnyStreamCollectionResponse>>(data, "items");
        }

        return null;
    }
}

