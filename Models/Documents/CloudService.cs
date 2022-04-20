using JsonSubTypes;

namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
[BsonIgnoreExtraElements]
public abstract class CloudService : UbluxDocument
{
    #region Properties

    /// <summary>
    ///     Identity that can login to this PBX. Must point to an identity of type PBX
    /// </summary>
        [AllowUpdate(false)]
    [References(typeof(Identity))]
    [Required]
    public string IdIdentity { get; set; } = string.Empty;

    // /// <summary>
    // ///     Example PBX-UST
    // /// </summary>
    //     // [AllowUpdate(false)]
    // [Required]
    // public string SubDomain
    // {
    //     get => (subDomain ?? "").ToLower();
    //     set
    //     {
    //         subDomain = value ?? "";
    //     }
    // }
    // private string subDomain = string.Empty;

    /// <summary>
    ///     Type of cloud service
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public abstract CloudServiceType CloudServiceType { get; }

    /// <summary>
    ///     Country where this system is located
    ///     Example: US, MX
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public CountryIsoCode CountryIsoCode { get; set; }

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
    [Required]
    public List<string> ExternalIps
    {
        get => _ExternalIps;
        set { if (value is null) _ExternalIps.Clear(); else _ExternalIps = value; }
    }
    List<string> _ExternalIps = new();


    /// <summary>
    ///     Is this service used as a backup pbx? Failover and NonFailover servers should NEVER overlap.         
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public bool IsFailover { get; set; }

    /// <summary>
    ///     Is there a router? For example on Divieto this will be true. On Canal Park this will be false
    /// </summary>
        [AllowUpdate(false)]
    public bool NAT { get; set; }

    ///// <summary>
    /////     MUI
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public string? MUI { get; set; }

    ///// <summary>
    /////     IF we are not able to send some configuration to pbx we flag it. Once pbx makes itself ready to be used
    /////     and downloads all the latest configuration we remove this flag.
    /////     
    /////     This is the only property that will trigger polling-broken-requires-make-ready-to-be-used
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool IsFlagged { get; set; }

    /// <summary>
    ///     Send this constantly to web service when polling. The pbx sends this
    /// </summary>
        [AllowUpdate(false)]
    public bool IsHealthy { get; set; }

    ///// <summary>
    /////     If pbx is rebooting or updating it will not be marked as offline/unhealthy; therefore, trunkOriginations will not be moved to failover pbx
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool IsRebootingOrUpdating { get; set; }

    #endregion
}
