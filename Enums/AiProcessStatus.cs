namespace Ublux.Communications.Enums;

/// <summary>
///     Status of something that is AI processed. 
///     For example the transcription of a call using whisper or analysis of call using chat GPT.
/// </summary>
public enum AiProcessStatus
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
    ///     Is in queue pending to be processed
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
