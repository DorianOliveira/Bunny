using BunnyStream.Net.Model.Response;
using Kyrios.BunnyStream.Model.Response;

namespace Kyrios.BunnyStream.Interfaces;

public interface IBunnyStreamCollectionsHandler: IBunnyRequester
{
    Task<BunnyStreamCollectionResponse?> CreateCollectionAsync(string libraryId, string name);
    Task<BunnyResponse?> UpdateCollectionAsync(string libraryId, Guid collectionId, string name);
    Task DeleteCollectionAsync(string libraryId, Guid collectionId);
    Task<ICollection<BunnyStreamCollectionResponse>?> GetCollectionListAsync(string libraryId);
}

