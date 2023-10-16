namespace Ublux.Communications.Models;

/// <summary>
///     Converted audio to text
/// </summary>
public class AiTranscription
{
    /// <summary>
    ///     Is it Agent or Client?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(20)]
    public required string Speaker { get; set; } = "";

    /// <summary>
    ///     Transcription text
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(2000)]
    public required string Text { get; set; } = "";

    /// <summary>
    ///     Number of seconds when this text was said
    /// </summary>
    public double StartTime { get; set; }

    /// <summary>
    ///     Number of seconds when this text ended being said
    /// </summary>
    public double EndTime { get; set; }   
}
