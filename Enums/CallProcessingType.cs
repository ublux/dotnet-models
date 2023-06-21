namespace Ublux.Communications.Enums;

/// <summary>
///     Type of extension
/// </summary>
public enum CallProcessingType
{
    /// <summary>
    ///     No type
    /// </summary>
    None,

    /// <summary>
    ///     Record the call
    /// </summary>
    Record,

    /// <summary>
    ///     Record and transcribe the call to text. There will be one transcription for the agent and another one for the client.
    /// </summary>
    Transcribe,

    /// <summary>
    ///     Record, transcribe and use AI to analyze the call
    /// </summary>
    AiAnalyze
}