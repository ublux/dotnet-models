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
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType
    {
        get => CloudServiceType.WH;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
