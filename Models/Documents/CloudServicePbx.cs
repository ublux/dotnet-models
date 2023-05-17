namespace Ublux.Communications.Models.Documents;

/// <summary>
///     PBX cloud service where phones connect
/// </summary>
public partial class CloudServicePbx : CloudService
{
    /// <summary>
    ///     If its NOT failover the the id of pbx that will act as failover. Else string empty string
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(CloudServicePbx))]
    // [IsUbluxRequired]
    public required string? IdCloudServicePbxFailover { get; set; } = string.Empty;

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

    /// <summary>
    ///     Http port where it is listening on SimpleTcpServer. For example PBX listens on port 8181
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int HttpListenPort { get; set; }
}