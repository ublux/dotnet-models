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
    public string HostName() => HostName(Id);

    /// <summary>
    ///     Examples:  csp-us-1.ublux.com  
    ///     Replace . with - on the id because we cannot have a subdomain
    /// </summary>
    public static string HostName(string idCloudServicePbx) => $"{idCloudServicePbx.Replace(".", "-")}.{Constants.Domain}".ToLower();
}

#endif
