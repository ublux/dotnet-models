#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Trunk used to receive phone calls
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
    ///     Id Provider
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(VoipProvider))]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string IdVoipProvider { get; set; }

    /// <summary>
    ///     Used by what PBX?
    ///     TODO: place index on db baced on this field
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(CloudServicePbx))]
    [IsUbluxRequired]
    public required string IdCloudServicePbx { get; set; }

    /// <summary>
    ///     Backup pbx
    ///     TODO: place index on db baced on this field
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(CloudServicePbx))]
    [IsUbluxRequired]
    public required string IdCloudServicePbxFailover { get; set; }

    // This can be ontained quering database
    ///// <summary>
    /////     Faxes and numbers used by this trunk
    ///// </summary>
    //[References(typeof(VoipNumber))]
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //[IsUbluxRequired]
    //public List<string> IdsVoipNumbers { get; set; } = new();

    #endregion

    #endregion

    /// <summary>
    ///     Type of trunk origination
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    [IsUbluxRequired]
    public abstract TrunkOriginationType TrunkOriginationType { get; }

    ///// <summary>
    /////     When a pbx goes offline or is unhealthy we will move this trunk origination to failover region
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool? IsMovedToFailoverRegion { get; set; }

    /// <summary>
    ///     Provider ID
    ///     Example: TKcc9b6e6d8f7394a4e896a5e6b7880110 for twilio
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string ProviderId { get; set; }

    ///// <summary>
    /////     DIDs associated with this trunk
    ///// </summary>
    //public List<string> Id_DIDs { get; set; }

    /// <summary>
    ///     Friendly name
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }

    ///// <summary>
    /////     Is connection secure?
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool IsSecure { get; set; }
}

#endif