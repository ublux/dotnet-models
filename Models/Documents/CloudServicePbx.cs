namespace Ublux.Communications.Models.Documents;

/// <summary>
///     PBX cloud service where phones connect
/// </summary>
public partial class CloudServicePbx : CloudService
{
    ///// <summary>
    /////     If its NOT failover the the id of pbx that will act as failover. Else string empty string
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[References(typeof(CloudServicePbx))]
    //// [IsUbluxRequired]
    //public required string? IdCloudServicePbxFailover { get; set; } = string.Empty;

    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType
    {
        get => CloudServiceType.PBX;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     If true we will not monitor pbx in order to update its soft dns in case it is not healthy
    /// </summary>
    [AllowUpdate(true)]
    public bool DisableMonitoring { get; set; }

    ///// <summary>
    /////     Http port where it is listening on SimpleTcpServer. For example PBX listens on port 8181
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[Obsolete("Remove this")]
    //public int HttpListenPort { get; set; }

    #region Gateway

    ///// <summary>
    /////     If pbx is behind a fxo gateway forward all PSTN incoming calls to this extension.
    /////     Can also be an extension number
    ///// </summary>
    //[AllowUpdate(true)]
    //[References(typeof(Extension))]
    //[Obsolete("gateway")]
    //public string? IdExtensionForwardCallsGateway { get; set; }

    // /// <summary>
    // ///     If it is a gateway then what type of processing for incoming calls
    // /// </summary>
    // [AllowUpdate(true)]
    // public CallProcessingType CallProcessingTypeGateway { get; set; }

    /// <summary>
    ///     If used as gateway then by what account
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Account))]
    public string? IdAccountGateway { get; set; }

    // /// <summary>
    // ///     Input to pass to AI engine
    // /// </summary>
    // [AllowUpdate(true)]
    // [References(typeof(AiCallAnalysisInput))]
    // public string? IdAiCallAnalysisInputGateway { get; set; }

    #endregion
}