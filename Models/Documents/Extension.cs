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
public abstract class Extension : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Music on hold to use
    /// </summary>
    [References(typeof(MusicOnHoldGroup))]
    [AllowUpdate(true)]
    public string? IdMusicOnHoldGroup { get; set; }

    /// <summary>
    ///     Audio to play before calling extension. It is common to play an audio that says that the call is being recorded for example.
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    public string? IdAudioToPlayBeforeCallingExtension { get; set; }

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [HideForCreateRequest]
    public abstract ExtensionType ExtensionType
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    }

    /// <summary>
    ///     Extension friendly name
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Extension number
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(1, 7)]
    public required string Number { get; set; } = string.Empty;

    /// <summary>
    ///     Inject extension name to caller id
    /// </summary>
    [AllowUpdate(true)]
    public bool InjectExtensionNameToCallerId { get; set; }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by number
        yield return new MongoDbIndex(collection, nameof(Number))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}