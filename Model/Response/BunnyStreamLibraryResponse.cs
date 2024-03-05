namespace Kyrios.BunnyStream.Model.Response;
public class BunnyStreamLibraryResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public long VideoCount { get; set; }
    public long TrafficUsage { get; set; }
    public long StorageUsage { get; set; }
    public DateTime DateCreated { get; set; }
    public string[] ReplicationRegions { get; set; }
    public string ApiKey { get; set; }
    public string ReadOnlyApiKey { get; set; }
    public bool HasWatermark { get; set; }
    public int WatermarkPositionLeft { get; set; }
    public int WatermarkPositionTop { get; set; }
    public int WatermarkWidth { get; set; }
    public int WatermarkHeight { get; set; }
    public long PullZoneId { get; set; }
    public long StorageZoneId { get; set; }
    public string EnabledResolutions { get; set; }
    public string ViAiPublisherId { get; set; }
    public string VastTagUrl { get; set; }
    public string WebhookUrl { get; set; }
    public int CaptionsFontSize { get; set; }
    public string CaptionsFontColor { get; set; }
    public string CaptionsBackground { get; set; }
    public string UILanguage { get; set; }
    public bool AllowEarlyPlay { get; set; }
    public bool PlayerTokenAuthenticationEnabled { get; set; }
    public string[] AllowedReferrers { get; set; }
    public string[] BlockedReferrers { get; set; }
    public bool BlockNoneReferrer { get; set; }
    public bool EnableMP4Fallback { get; set; }
    public bool KeepOriginalFiles { get; set; }
    public bool AllowDirectPlay { get; set; }
    public bool EnableDRM { get; set; }
    public int Bitrate240p { get; set; }
    public int Bitrate360p { get; set; }
    public int Bitrate480p { get; set; }
    public int Bitrate720p { get; set; }
    public int Bitrate1080p { get; set; }
    public int Bitrate1440p { get; set; }
    public int Bitrate2160p { get; set; }
    public string ApiAccessKey { get; set; }
    public bool ShowHeatmap { get; set; }
    public bool EnableContentTagging { get; set; }
    public int PullZoneType { get; set; }
    public string CustomHTML { get; set; }
    public string Controls { get; set; }
    public string PlayerKeyColor { get; set; }
    public string FontFamily { get; set; }
    public long WatermarkVersion { get; set; }
    public bool EnableTranscribing { get; set; }
    public bool EnableTranscribingTitleGeneration { get; set; }
    public bool EnableTranscribingDescriptionGeneration { get; set; }
    public List<string> TranscribingCaptionLanguages { get; set; }




}



