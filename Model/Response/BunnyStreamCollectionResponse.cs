namespace BunnyStream.Net.Model.Response;
public class BunnyStreamCollectionResponse
{
    public int VideoLibraryId { get; set; }
    public Guid Guid { get; set; }
    public string? Name { get; set; }
    public int VideoCount { get; set; }
    public long TotalSize { get; set; }
    public string? PreviewVideoIds { get; set; }
}