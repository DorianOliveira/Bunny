using BunnyStream.Net.Model.Response;
using Kyrios.BunnyStream.Model;
using Kyrios.BunnyStream.Model.Response;

namespace Kyrios.BunnyStream.Interfaces;

public interface IBunnyStreamLibraryHandler : IBunnyRequester
{
    Task<BunnyStreamLibraryResponse?> GetAsync(string libraryId);
    Task DeleteAsync(string libraryId);
    Task<BunnyStreamLibraryResponse?> AddAsync(string name);
    Task<BunnyStreamLibraryResponse?> UpdateAsync(BunnyStreamLibraryRequest request);
    Task AddAllowedRefererAsync(string libraryId, string host);
    Task RemoveAllowedRefererAsync(string libraryId, string host);
    Task AddBlockedRefererAsync(string libraryId, string host);
    Task RemoveBlockedRefererAsync(string libraryId, string host);
     
}

