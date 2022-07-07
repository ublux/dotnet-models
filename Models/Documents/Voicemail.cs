namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Extensions may forward an existing voicemail to another extension
/// </summary>
/* Attributes that help with deserialization */
[JsonConverter(typeof(JsonSubtypes), nameof(VoicemailType))]
[JsonSubtypes.KnownSubType(typeof(Voicemail), nameof(VoicemailType.Regular))]
[JsonSubtypes.KnownSubType(typeof(VoicemailForwarded), nameof(VoicemailType.Forwarded))]
[BsonKnownTypes(
    typeof(Voicemail),
    typeof(VoicemailForwarded))]
public partial class Voicemail : UbluxDocument
{
    /// <summary>
    ///     Type of voicemail
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public virtual VoicemailType VoicemailType => VoicemailType.Regular;

    /// <summary>
    ///     Ids of lines that can listen to voicemail
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Line))]
    public List<string> IdsLinesThatCanListenToVoicemail { get; set; } = new();

    /// <summary>
    ///     Email where voicemail was sent
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string Email { get; set; }

    /// <summary>
    ///     Voicemail duration in seconds
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required int DurationInSeconds { get; set; }

    /// <summary>
    ///     Voicemail in wav format. Optional because there may be an error
    /// </summary>
    [AllowUpdate(false)]
    public StoredFile? VoicemailWav { get; set; }

    /// <summary>
    ///     Voicemail in mp3 format. Optional because there may be an error
    /// </summary>
    [AllowUpdate(false)]
    public StoredFile? VoicemailMp3 { get; set; }

    /// <summary>
    ///     If there is an error sending the voicemail then the error description
    /// </summary>
    [AllowUpdate(false)]
    public string? ErrorMessage { get; set; }
}
