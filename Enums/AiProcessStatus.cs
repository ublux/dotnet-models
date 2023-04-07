namespace Ublux.Communications.Enums;

/// <summary>
///     Status of something that is AI processed. 
///     For example the transcription of a call using whisper or analysis of call using chat GPT.
/// </summary>
public enum AiProcessStatus
{    
    /// <summary>
    ///     Pending to be processed
    /// </summary>
    Pending,

    /// <summary>
    ///     Its being processed
    /// </summary>
    Processing,

    /// <summary>
    ///     Its done being processed
    /// </summary>
    Complete
}
