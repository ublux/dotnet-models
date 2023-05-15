namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Base class for cloud services
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CloudServiceType))]
[JsonSubtypes.KnownSubType(typeof(CloudServicePbx), nameof(CloudServiceType.PBX))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceWebApp), nameof(CloudServiceType.WA))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceWebHost), nameof(CloudServiceType.WH))]
//[JsonSubtypes.KnownSubType(typeof(CloudServiceWebService), nameof(CloudServiceType.WS))]
[BsonKnownTypes(
    typeof(CloudServicePbx),
    typeof(CloudServiceWebApp),
    typeof(CloudServiceWebHost)
//typeof(CloudServiceWebService)
)]
public abstract partial class CloudService : UbluxDocument
{
    #region Properties

    /// <summary>
    ///     TODO. Place index on this field on DB
    ///     Thanks to the user it can login
    /// </summary>
    [References(typeof(User))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required string IdUser { get; set; } = string.Empty;

    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [HideForCreateRequest]
    public abstract CloudServiceType CloudServiceType
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    }

    /// <summary>
    ///     Country where this system is located
    ///     Example: US, MX
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     If this service is inside a nat what is the local ip address?
    ///     This is needed by asterisk sip.conf file
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public string? Localnet { get; set; }

    ///// <summary>
    /////     If this Linux cloud service is inside a NAT then what is the public ip address.
    /////     This is needed by asterisk sip.conf file
    ///// 
    /////     It is a list because sometimes it may contain multiple public ips. For example in namschul we get requests of ip phones from a different ip
    ///// </summary>
    //[AllowUpdate(false)]
    //[IsUbluxRequired]
    //public List<string> ExternalIps { get; set; } = new();

    /// <summary>
    ///     It can have multipe ips but only one should be used.
    ///     Hard host name should point to this
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public string? ExternalIp { get; set; }

    /// <summary>
    ///     Is this service used as a backup pbx? Failover and NonFailover servers should NEVER overlap.         
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required bool IsFailover { get; set; }

    /// <summary>
    ///     Is there a router? For example on Divieto this will be true. On Canal Park this will be false
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required bool Nat { get; set; }

    /// <summary>
    ///     Send this constantly to web service when polling. The pbx sends this
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public bool IsHealthy { get; set; }

    /// <summary>
    ///     Instance Id. Example PBX-US-1 for CSP.PBX-US-1
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(50)]
    public required string InstanceId { get => instanceId; set => instanceId = value.ToUpper(); }
    private string instanceId = string.Empty;

    /// <summary>
    ///     Is this a test cloud serviec
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public bool IsTest { get; set; }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;        
    }

    #endregion
}
