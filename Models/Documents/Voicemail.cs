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
public partial class Voicemail : UbluxDocument, IReferencesTags
{
    #region References

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    /// <summary>
    ///     Ids of lines that can listen to voicemail
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Line))]
    public List<string> IdsLinesThatCanListenToVoicemail { get; set; } = new();

    #endregion

    /// <summary>
    ///     Type of voicemail
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public virtual VoicemailType VoicemailType => VoicemailType.Regular;

    /// <summary>
    ///     Email where voicemail was sent
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string Email { get; set; }

    /// <summary>
    ///     Voicemail duration in seconds
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
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
