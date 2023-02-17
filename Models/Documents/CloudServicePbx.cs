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
    public required string? IdCloudServicePbxFailover { get; set; }

    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType
    {
        get => CloudServiceType.PBX;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
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