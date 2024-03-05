using BunnyStream.Net.Model.Response;
using Kyrios.BunnyStream.Model.Response;

namespace Kyrios.BunnyStream.Interfaces;

public interface IBunnyStreamVideoHandler : IBunnyRequester
{
    Task<BunnyStreamVideoResponse?> UploadVideoAsync(string libraryId, Guid? collectionId, Stream videoStream, string videoName);
    Task<BunnyStreamVideoResponse?> GetVideoAsync(string libraryId, Guid videoId);
    
}

