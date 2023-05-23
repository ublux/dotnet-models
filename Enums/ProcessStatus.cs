namespace Ublux.Communications.Enums;

/// <summary>
///     Status of something that is being processed. 
///     For example the transcription of a call using whisper or analysis of call using chat GPT.
/// </summary>
public enum ProcessStatus
{   
    /// <summary>
    ///     If its not being processed
    /// </summary>
    None,

    /// <summary>
    ///     Pending to be processed
    /// </summary>
    Pending,

    /// <summary>
    ///     It is about to be processed
    /// </summary>
    Queued,

    /// <summary>
    ///     Its being processed
    /// </summary>
    Processing,

    /// <summary>
    ///     Its done being processed
    /// </summary>
    Complete
}
