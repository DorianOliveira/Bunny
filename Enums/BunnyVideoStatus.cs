namespace BunnyStream.Net.Enums;

public enum BunnyVideoStatus
{
    Queued,
    Processing,
    Encoding,
    Finished,
    ResolutionFinished,
    Failed,
    PresignedUploadStarted,
    PresignedUploadFailed,
    CaptionsGenerated,
    TitleOrDescipritionGenerated
}