namespace Ublux.Communications.Models.Documents;

/// <summary>
///     AI transcription of a phone call. This is the convertion from audio to text only.
/// </summary>
public partial class AiCallTranscription : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region References        

    /// <summary>
    ///     Call being transcribed
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Call))]
    [IsUbluxRequired]
    public string IdCall { get; set; } = string.Empty; // OK

    #endregion

    /// <summary>
    ///     If there is a language it means there is a transcription
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? TranscriptionLanguage { get; set; }

    /// <summary>
    ///     Audio of agent converted to text
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiTranscription> Transcription { get; set; } = new(); // OK

    /// <summary>
    ///     If the transcription contains an error
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ErrorMessage { get; set; }
    
}