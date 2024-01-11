namespace Ublux.Communications.Models;

/// <summary>
///     Call errors
/// </summary>
public class CallErrors
{
    /// <summary>
    ///     Errors with call in general. For example: Call made to none existing extension.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> ErrorsCall { get; set; } = [];

    /// <summary>
    ///     Errors with call recoding. For example: It was not possible to store recording.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> ErrorsRecording { get; set; } = [];

    /// <summary>
    ///     Errors with dealing converting call audio to text. For example: Transcription service is not available; therefore, it was not possible to transcribe call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> ErrorsAiTranscription { get; set; } = [];

    /// <summary>
    ///     Errors with AI engine. For example: Call is too short and does not contain any relevant information to be AI analyzed.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> ErrorsAiAnalysis { get; set; } = [];
}
