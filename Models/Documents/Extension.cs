namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Extension could be of type basic,queue,conference,voicemail or callFlowLogic
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(ExtensionType))]
[JsonSubtypes.KnownSubType(typeof(ExtensionCallFlowLogic), nameof(ExtensionType.CallFlowLogic))]
[JsonSubtypes.KnownSubType(typeof(ExtensionConference), nameof(ExtensionType.Conference))]
[JsonSubtypes.KnownSubType(typeof(ExtensionDial), nameof(ExtensionType.Dial))]
[JsonSubtypes.KnownSubType(typeof(ExtensionQueue), nameof(ExtensionType.Queue))]
[JsonSubtypes.KnownSubType(typeof(ExtensionVoicemail), nameof(ExtensionType.Voicemail))]
[BsonKnownTypes(
    typeof(ExtensionCallFlowLogic),
    typeof(ExtensionConference),
    typeof(ExtensionDial),
    typeof(ExtensionQueue),
    typeof(ExtensionVoicemail)
)]
[DebuggerDisplay("Name:{FriendlyName} Number:{Number} ExtensionType:{ExtensionType}")]
public abstract partial class Extension : UbluxDocument
{
    #region Properties

    #region References

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
    [IsRequired]
    [HideForCreateRequest]
    public abstract ExtensionType ExtensionType { get; }

    /// <summary>
    ///     Extension friendly name
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Extension number
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required string Number { get; set; }

    /// <summary>
    ///     Inject extension name to caller id
    /// </summary>
    [AllowUpdate(true)]
    public bool InjectExtensionNameToCallerId { get; set; }

    #endregion
}