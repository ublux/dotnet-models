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
    [SwaggerSchema(ReadOnly = true)]     
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType
    {
        get => CloudServiceType.WA;        
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     In case web-app fails point it to another one
    /// </summary>
    [References(typeof(CloudServiceWebApp))]
    [AllowUpdate(true)]
    public string? IdCloudServiceWebAppFailover { get; set; }
}
