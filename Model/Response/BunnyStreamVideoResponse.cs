using BunnyStream.Net.Enums;
namespace BunnyStream.Net.Model.Response;

public class BunnyStreamVideoResponse
{
    public int VideoLibraryId { get; set; }
    public Guid Guid { get; set; }
    public string? CollectionId { get; set; }
    public string? Title { get; set; }
    public DateTime DateUploaded { get; set; }
    public int Views { get; set; }
    public int Length { get; set; }
    public string? AvailableResolutions { get; set; }
    public string? ThumbnailFileName { get; set; }
    public BunnyVideoStatus Status { get; set; }
    public long StorageSize { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

}

