namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Base class for cloud services
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CloudServiceType))]
[JsonSubtypes.KnownSubType(typeof(CloudServicePbx), nameof(CloudServiceType.PBX))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceWebApp), nameof(CloudServiceType.WA))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceWebHost), nameof(CloudServiceType.WH))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceWebService), nameof(CloudServiceType.WS))]
[BsonKnownTypes(
    typeof(CloudServicePbx),
    typeof(CloudServiceWebApp),
    typeof(CloudServiceWebHost),
    typeof(CloudServiceWebService)
)]
public abstract class CloudService : UbluxDocument
{
    #region Properties

    ///// <summary>
    /////     Identity that can login to this PBX. Must point to an identity of type PBX
    ///// </summary>
    //[AllowUpdate(false)]
    //[References(typeof(Identity))]
    //[IsRequired]
    //public string required IdIdentity { get; set; }

    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public abstract CloudServiceType CloudServiceType { get; }

    /// <summary>
    ///     Country where this system is located
    ///     Example: US, MX
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     If this service is inside a nat what is the local ip address?
    ///     This is needed by asterisk sip.conf file
    /// </summary>
    [AllowUpdate(false)]
    public string? Localnet { get; set; }

    /// <summary>
    ///     If this Linux cloud service is inside a NAT then what is the public ip address.
    ///     This is needed by asterisk sip.conf file
    /// 
    ///     It is a list because sometimes it may contain multiple public ips. For example in namschul we get requests of ip phones from a different ip
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public List<string> ExternalIps { get; set; } = new();


    /// <summary>
    ///     Is this service used as a backup pbx? Failover and NonFailover servers should NEVER overlap.         
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required bool IsFailover { get; set; }

    /// <summary>
    ///     Is there a router? For example on Divieto this will be true. On Canal Park this will be false
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required bool Nat { get; set; }

    /// <summary>
    ///     Send this constantly to web service when polling. The pbx sends this
    /// </summary>
    [AllowUpdate(false)]
    public bool IsHealthy { get; set; }

    #endregion     
}
