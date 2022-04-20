namespace Ublux.Communications.Models.Documents;

// ReSharper disable ConditionIsAlwaysTrueOrFalse
/// <summary>
///     PBX cloud service where phones connect
/// </summary>
public partial class CloudServicePbx : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType => CloudServiceType.PBX;
}