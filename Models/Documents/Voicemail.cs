using JsonSubTypes;

namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Extensions may forward an existing voicemail to another extension
/// </summary>
/// <summary>
///     Extension could be of type basic,queue,conference,voicemail or callFlow
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(VoicemailType))]
[JsonSubtypes.KnownSubType(typeof(Voicemail), nameof(VoicemailType.Regular))]
[JsonSubtypes.KnownSubType(typeof(VoicemailForwarded), nameof(VoicemailType.Forwarded))]
[BsonKnownTypes(
    typeof(Voicemail),
    typeof(VoicemailForwarded)
)]
[BsonIgnoreExtraElements]
public partial class Voicemail : UbluxDocument
{
    /// <summary>
    ///     Type of voicemail
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public virtual VoicemailType VoicemailType => VoicemailType.Regular;

    /// <summary>
    ///     Ids of lines that can listen to voicemail
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Line))]
    public List<string> IdsLinesThatCanListenToVoicemail
    {
        get => _IdsLinesThatCanListenToVoicemail;
        set { if (value is null) _IdsLinesThatCanListenToVoicemail.Clear(); else _IdsLinesThatCanListenToVoicemail = value; }
    }
    List<string> _IdsLinesThatCanListenToVoicemail = new();

    /// <summary>
    ///     Email where voicemail was sent
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     Voicemail duration in seconds
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public int DurationInSeconds { get; set; }

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
