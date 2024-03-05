using BunnyStream.Net.Enums;
namespace Kyrios.BunnyStream.Model.Response;
public class BunnyWebhookResponse
{
    public string LibraryId { get; set; }
    public Guid VideoGuid { get; set; }
    public BunnyVideoStatus Status { get; set; }
}