namespace Kyrios.BunnyStream.Model.Request
{
    public class BunnyCreateVideoRequest(string? title = "", string? collectionId = "") : BaseRequest
    {
        public string? Title { get; set; } = title;
        public string? CollectionId { get; set; } = collectionId;
    }

    public class BunnyCreateCollectionRequest(string? name = "") : BaseRequest
    {
        public string? Name { get; set; } = name;
    }

    public class BunnyUpdateCollectionRequest(string  name = "") : BaseRequest
    {
        public string? Name { get; set; } = name;
    }
}