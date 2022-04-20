using JsonSubTypes;

namespace Ublux.Communications.Domain.Models.Documents;

// ReSharper disable ConditionIsAlwaysTrueOrFalse
/// <summary>
///     Extension could be of type basic,queue,conference,voicemail or callFlow
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(ExtensionType))]
[JsonSubtypes.KnownSubType(typeof(ExtensionCallFlow), nameof(ExtensionType.CallFlow))]
[JsonSubtypes.KnownSubType(typeof(ExtensionConference), nameof(ExtensionType.Conference))]
[JsonSubtypes.KnownSubType(typeof(ExtensionDial), nameof(ExtensionType.Dial))]
[JsonSubtypes.KnownSubType(typeof(ExtensionQueue), nameof(ExtensionType.Queue))]
[JsonSubtypes.KnownSubType(typeof(ExtensionVoicemail), nameof(ExtensionType.Voicemail))]
[BsonKnownTypes(
    typeof(ExtensionCallFlow),
    typeof(ExtensionConference),
    typeof(ExtensionDial),
    typeof(ExtensionQueue),
    typeof(ExtensionVoicemail)
)]
[BsonIgnoreExtraElements]
public abstract class Extension : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Music on hold to use
    /// </summary>
    [References(typeof(MusicOnHoldGroup))]
    [AllowUpdate(true)]
    public string? IdMusicOnHoldGroup { get; set; }

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public abstract ExtensionType ExtensionType { get; }

    /// <summary>
    ///     Extension number
    /// </summary>
    [AllowUpdate(true)]
    [Required]
    public string Number { get; set; } = String.Empty;

    /// <summary>
    ///     Inject extension name to caller id
    /// </summary>
    [AllowUpdate(true)]
    public bool InjectExtensionNameToCallerId { get; set; }

    #endregion
}