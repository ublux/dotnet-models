namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux API cloud service
/// </summary>
public partial class CloudServiceWebService : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType => CloudServiceType.WS;
}
