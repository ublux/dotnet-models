#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Base class for cloud services
/// </summary>
public abstract partial class CloudService : UbluxDocument
{
    /// <summary>
    ///     Examples:  csp.us-1.ublux.com            
    /// </summary>
    public string HostName() => HostName(this.id);

    /// <summary>
    ///     Examples:  csp.us-1.ublux.com            
    /// </summary>
    public static string HostName(string idCloudServicePbx) => $"{idCloudServicePbx}.{Constants.Domain}".ToLower();
}

#endif
