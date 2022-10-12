namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Web app where web-phone lives
/// </summary>
public partial class CloudServiceWebApp : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType
    {
        get => CloudServiceType.WA;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}
