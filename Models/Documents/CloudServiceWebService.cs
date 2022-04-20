namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Ublux API cloud service
/// </summary>
public partial class CloudServiceWebService : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType => CloudServiceType.WS;
}
