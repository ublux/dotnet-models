﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Base class for cloud services
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CloudServiceType))]
[JsonSubtypes.KnownSubType(typeof(CloudServicePbx), nameof(CloudServiceType.PBX))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceWebApp), nameof(CloudServiceType.WA))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceWebHost), nameof(CloudServiceType.WH))]
[JsonSubtypes.KnownSubType(typeof(CloudServiceTranscription), nameof(CloudServiceType.TS))]
//[JsonSubtypes.KnownSubType(typeof(CloudServiceWebService), nameof(CloudServiceType.API))]
[BsonKnownTypes(
    typeof(CloudServicePbx),
    typeof(CloudServiceWebApp),
    typeof(CloudServiceWebHost),
    typeof(CloudServiceTranscription)
//typeof(CloudServiceWebService)
)]
public abstract partial class CloudService : UbluxDocument
{
    #region Properties

    /// <summary>
    ///     Cloud services can authenticate differently than users. Makes no sense for a pbx for example to have an email address
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string Password { get; set; }

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
    
    /// <summary>
    ///     It can have multiple ips but only one should be used.
    ///     Hard host name should point to this
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public string? ExternalIp { get; set; }

    ///// <summary>
    /////     Is this service used as a backup pbx? Failover and NonFailover servers should NEVER overlap.         
    ///// </summary>
    //[AllowUpdate(false)] 
    //[SwaggerSchema(ReadOnly = true)] 
    //[UbluxValidationRequired]
    //public required bool IsFailover { get; set; }

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
    ///     Date when cloud service got disconnected
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateDisconnected { get; set; }

    ///// <summary>
    /////     Instance Id. Example PBX-US-1 for CSP.PBX-US-1
    ///// </summary>
    //[AllowUpdate(false)] 
    //[SwaggerSchema(ReadOnly = true)]
    //[UbluxValidationStringRange(50)]
    //[UbluxValidationRequired]
    //public required string InstanceId { get => instanceId; set => instanceId = value.ToUpper(); }
    //private string instanceId = string.Empty;

    /// <summary>
    ///     Is this a test cloud service?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public bool IsTest { get; set; }


    /// <summary>
    ///     We need instance id in order to reboot cloud service for example. Example: i-0655b45b8134e6425 
    /// </summary>
    [AllowUpdate(true)]
    public string? ProviderInstanceId { get; set; }

    /// <summary>
    ///     Region is needed to connect to EC2 instance when using AWS for example: USEast1 or EUWest3 for europe paris
    /// </summary>
    [AllowUpdate(true)]
    public string? ProviderRegion { get; set; }

    /// <summary>
    ///     Example AWS for amazon web services
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public required CloudServiceProviderType ProviderType { get; set; }

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
    }

    #endregion
}
