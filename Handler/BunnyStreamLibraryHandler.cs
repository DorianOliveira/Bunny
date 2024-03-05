using BunnyStream.Net.Model.Response;
using Kyrios.BunnyStream.Interfaces;
using Kyrios.BunnyStream.Model;
using Kyrios.BunnyStream.Model.Request;
using Kyrios.BunnyStream.Model.Response;
using Kyrios.Helpers;
using System.Net;

namespace Kyrios.BunnyStream.Handler;

public class BunnyStreamLibraryHandler(BunnyApiHandlerOptions options)
    : BunnyApiHandler(options.BaseUrl, options.StreamLibraryResourceName, options.ApiKey), IBunnyStreamLibraryHandler
{
    public Task AddAllowedRefererAsync(string libraryId, string host)
    {
        throw new NotImplementedException();
    }

    public Task<BunnyStreamLibraryResponse?> AddAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task AddBlockedRefererAsync(string libraryId, string host)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string libraryId)
    {
        throw new NotImplementedException();
    }

    public Task<BunnyStreamLibraryResponse?> GetAsync(string libraryId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAllowedRefererAsync(string libraryId, string host)
    {
        throw new NotImplementedException();
    }

    public Task RemoveBlockedRefererAsync(string libraryId, string host)
    {
        throw new NotImplementedException();
    }

    public Task<BunnyStreamLibraryResponse?> UpdateAsync(BunnyStreamLibraryRequest request)
    {
        throw new NotImplementedException();
    }
}
