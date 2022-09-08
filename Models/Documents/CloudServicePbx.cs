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
    [References(typeof(CloudServicePbx))]
    [IsRequired]
    public required string IdCloudServicePbxFailover { get; set; }    

    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType => CloudServiceType.PBX;
}