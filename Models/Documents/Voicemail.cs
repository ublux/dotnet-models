﻿namespace Ublux.Communications.Models.Documents;

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
    public List<string> IdsTags { get; set; } = new();

    /// <summary>
    ///     Ids of lines that can listen to voicemail
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Line))]
    public List<string> IdsLinesThatCanListenToVoicemail { get; set; } = new();

    /// <summary>
    ///     Email where voicemail was sent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    [References(typeof(Email))]
    public required string IdEmail { get; set; } = "";

    #endregion

    /// <summary>
    ///     Type of voicemail
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public virtual VoicemailType VoicemailType => VoicemailType.Regular;

    /// <summary>
    ///     Voicemail duration in seconds
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required int DurationInSeconds { get; set; }

    /// <summary>
    ///     Voicemail in wav format. Optional because there may be an error
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public StoredFile? VoicemailWav { get; set; }

    /// <summary>
    ///     Voicemail in mp3 format. Optional because there may be an error
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public StoredFile? VoicemailMp3 { get; set; }

    /// <summary>
    ///     If there is an error sending the voicemail then the error description
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? ErrorMessage { get; set; }
}
