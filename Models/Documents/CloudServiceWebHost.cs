namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Server where ublux website lives
/// </summary>
public partial class CloudServiceWebHost : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType => CloudServiceType.WH;
}
