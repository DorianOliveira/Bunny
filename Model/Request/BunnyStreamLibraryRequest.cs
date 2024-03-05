namespace Kyrios.BunnyStream.Model.Response;
public class BunnyStreamLibraryRequest
{
    /// <summary>
    /// (Optional) Sets name of the video library
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// (Optional) Sets the player custom HTML code
    /// </summary>
    public string CustomHTML { get; set; }

    /// <summary>
    /// (Optional) Sets the player key control color
    /// </summary>
    public string PlayerKeyColor { get; set; }

    /// <summary>
    /// (Optional) Determines if the token authentication should be enabled
    /// </summary>
    public bool EnableTokenAuthentication { get; set; }

    /// <summary>
    /// (Optional) Determines if the token IP verification should be enabled
    /// </summary>
    public bool EnableTokenIPVerification { get; set; }

    /// <summary>
    /// (Optional) Set to true to reset the CDN and embed view token key
    /// </summary>
    public bool ResetToken { get; set; }

    /// <summary>
    /// (Optional) Sets the left offset of the watermark position (in %)
    /// </summary>
    public int WatermarkPositionLeft { get; set; }

    /// <summary>
    /// (Optional) Sets the top offset of the watermark position (in %)
    /// </summary>
    public int WatermarkPositionTop { get; set; }

    /// <summary>
    /// (Optional) Sets the width of the watermark (in %)
    /// </summary>
    public int WatermarkWidth { get; set; }

    /// <summary>
    /// (Optional) Sets the height of the watermark (in %)
    /// </summary>
    public int WatermarkHeight { get; set; }

    /// <summary>
    /// (Optional) Sets the enabled resolutions for the transcoding.
    /// At least one resolution should be enabled. Possible values: 240p, 360p, 480p, 720p, 1080p, 1440p, 2160p
    /// </summary>
    public string EnabledResolutions { get; set; }

    /// <summary>
    /// (Optional) Sets the vi.ai publisher ID
    /// </summary>
    public string ViAiPublisherId { get; set; }

    /// <summary>
    /// (Optional) Sets the Vast tag URL
    /// </summary>
    public string VastTagUrl { get; set; }

    /// <summary>
    /// (Optional) Sets the webhook API url
    /// </summary>
    public string WebhookUrl { get; set; }

    /// <summary>
    /// (Optional) Sets the captions display font size
    /// </summary>
    public int CaptionsFontSize { get; set; }

    /// <summary>
    /// (Optional) Sets the captions display font color
    /// </summary>
    public string CaptionsFontColor { get; set; }

    /// <summary>
    /// (Optional) Sets the captions display background color
    /// </summary>
    public string CaptionsBackground { get; set; }

    /// <summary>
    /// (Optional) Sets the UI language of the video player.
    /// </summary>
    public string UILanguage { get; set; }

    /// <summary>
    /// (Optional) Determines if the Early-Play feature should be enabled.
    /// </summary>
    public bool AllowEarlyPlay { get; set; }

    /// <summary>
    /// (Optional) Determines if the token authentication should be enabled.
    /// </summary>
    public bool PlayerTokenAuthenticationEnabled { get; set; }

    /// <summary>
    /// (Optional) Determines if requests without a referer should be blocked.
    /// </summary>
    public bool BlockNoneReferrer { get; set; }

    /// <summary>
    /// (Optional) Determines if MP4 fallback should be enabled for this library.
    /// </summary>
    public bool EnableMP4Fallback { get; set; }

    /// <summary>
    /// (Optional) Determines if the original file should be kept after the video is processed.
    /// </summary>
    public bool KeepOriginalFiles { get; set; }

    /// <summary>
    /// (Optional) Determines if direct play URLs should be enabled for the library.
    /// </summary>
    public bool AllowDirectPlay { get; set; }

    /// <summary>
    /// (Optional) Determines if MediaCage basic DRM should be enabled for this library.
    /// </summary>
    public bool EnableDRM { get; set; }

    /// <summary>
    /// (Optional) The comma separated list of controls that will be displayed in the video player.
    /// Possible values: play-large, play, progress, current-time, mute, volume, captions, settings, pip, airplay, fullscreen.
    /// </summary>
    public string Controls { get; set; }

    /// <summary>
    /// (Optional) The bitrate used for encoding 240p videos
    /// </summary>
    public int Bitrate240p { get; set; }

    /// <summary>
    /// (Optional) The bitrate used for encoding 360p videos
    /// </summary>
    public int Bitrate360p { get; set; }

    /// <summary>
    /// (Optional) The bitrate used for encoding 480p videos
    /// </summary>
    public int Bitrate480p { get; set; }

    /// <summary>
    /// (Optional) The bitrate used for encoding 720p videos
    /// </summary>
    public int Bitrate720p { get; set; }

    /// <summary>
    /// (Optional) The bitrate used for encoding 1080p videos
    /// </summary>
    public int Bitrate1080p { get; set; }

    /// <summary>
    /// (Optional) The bitrate used for encoding 1440p videos
    /// </summary>
    public int Bitrate1440p { get; set; }

    /// <summary>
    /// (Optional) The bitrate used for encoding 2160p videos
    /// </summary>
    public int Bitrate2160p { get; set; }

    /// <summary>
    /// Determines if the video watch heatmap should be displayed in the player.
    /// </summary>
    public bool ShowHeatmap { get; set; }

    /// <summary>
    /// Determines if content tagging should be enabled for this library.
    /// </summary>
    public bool EnableContentTagging { get; set; }

    /// <summary>
    /// The captions font family.
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// (Optional) Determines if the automatic audio transcribing is currently enabled for this zone.
    /// </summary>
    public bool EnableTranscribing { get; set; }

    /// <summary>
    /// (Optional) Determines if automatic transcribing title generation is currently enabled.
    /// </summary>
    public bool EnableTranscribingTitleGeneration { get; set; }

    /// <summary>
    /// (Optional) Determines if automatic transcribing description generation is currently enabled.
    /// </summary>
    public bool EnableTranscribingDescriptionGeneration { get; set; }

    /// <summary>
    /// (Optional) The list of languages that the captions will be automatically transcribed to.
    /// </summary>
    public IEnumerable<string> TranscribingCaptionLanguages { get; set; }
}



