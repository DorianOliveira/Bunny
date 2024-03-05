using BunnyStream.Net.Handler.Base;
using BunnyStream.Net.Model.Response;
using Kyrios.BunnyStream.Interfaces;
using Kyrios.BunnyStream.Model;
using Kyrios.BunnyStream.Model.Request;
using Kyrios.Helpers;
using System.Net;

namespace Kyrios.BunnyStream.Handler;

public class BunnyStreamVideoHandler(BunnyStreamHandlerOptions options) : 
    BunnyStreamBaseHandler(options.BaseUrl, options.StreamLibraryResourceName, options.ApiKey), IBunnyStreamVideoHandler
{
    public async Task<BunnyStreamVideoResponse?> UploadVideoAsync(string libraryId, Guid? collectionId, Stream videoStream, string videoName)
    {
        var url = BuildRequestUrl(libraryId);

        using var httpClient = GetHttpClient();

        var videoRequest = new BunnyCreateVideoRequest(videoName);

        if (collectionId != null)
            videoRequest.CollectionId = collectionId.Value.ToString();

        var responseVideoInfo = await httpClient.PostAsync(url, videoRequest.ToStringContent());
        var videoInfoData = await responseVideoInfo.Content.ReadAsStringAsync();

        if (responseVideoInfo.StatusCode != HttpStatusCode.OK)
            return null;

        var bunnyVideo = RequestHelper.GetObjectFromRoot<BunnyStreamVideoResponse>(videoInfoData);
        var responseUpload = await httpClient.PutAsync($"{url}/{bunnyVideo.Guid}", new StreamContent(videoStream));

        if (responseUpload.StatusCode != HttpStatusCode.OK)
            return null;

        return bunnyVideo;
    }

    public async Task<BunnyStreamVideoResponse?> GetVideoAsync(string libraryId, Guid videoId)
    {
        var url = BuildRequestUrl(libraryId, videoId.ToString());

        using var httpClient = GetHttpClient();

        var response = await httpClient.GetAsync(url);

        if (response.StatusCode != HttpStatusCode.OK)
            return null;

        return RequestHelper.GetObjectFromRoot<BunnyStreamVideoResponse>(await response.Content.ReadAsStringAsync());
    }

}
