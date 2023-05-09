#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Trunk used to receive phone calls. Multiple VoipNumbers can point to the same trunk origination.
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(TrunkOriginationType))]
[JsonSubtypes.KnownSubType(typeof(TrunkOriginationForward), nameof(TrunkOriginationType.Forward))]
[JsonSubtypes.KnownSubType(typeof(TrunkOriginationRegister), nameof(TrunkOriginationType.Register))]
[BsonKnownTypes(
    typeof(TrunkOriginationForward),
    typeof(TrunkOriginationRegister)
)]
public abstract class TrunkOrigination : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Id Provider. Example: Twilio
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(VoipProvider))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string IdVoipProvider { get; set; } = string.Empty;

    /// <summary>
    ///     Used by what PBX?
    ///     TODO: place index on db baced on this field
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(CloudServicePbx))]
    [IsUbluxRequired]
    public required string IdCloudServicePbx { get; set; } = string.Empty;

    /// <summary>
    ///     Backup pbx
    ///     TODO: place index on db baced on this field
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(CloudServicePbx))]
    [IsUbluxRequired]
    public required string IdCloudServicePbxFailover { get; set; } = string.Empty;

    #endregion

    #endregion

    /// <summary>
    ///     Type of trunk origination
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    [IsUbluxRequired]
    public abstract TrunkOriginationType TrunkOriginationType
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    }

    /// <summary>
    ///     Provider ID
    ///     Example: TKcc9b6e6d8f7394a4e896a5e6b7880110 for twilio
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string ProviderId { get; set; } = string.Empty;

    /// <summary>
    ///     Friendly name
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; } = string.Empty;

}

#endif