using BunnyStream.Net.Enums;
namespace Kyrios.BunnyStream.Model.Response;

public class BunnyStreamVideoWebhookResponse
{
    public int VideoLibraryId { get; set; }
    public Guid VideoGuid { get; set; }
    public BunnyVideoStatus Status { get; set; }
}



