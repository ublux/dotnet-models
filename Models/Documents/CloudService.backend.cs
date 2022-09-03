#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Base class for cloud services
/// </summary>
public abstract partial class CloudService : UbluxDocument
{
    /// <summary>
    ///     Examples:  
    ///         us1.ublux.com for csp.us1 pbx
    ///         1.ublux.com for csws.1 web service
    ///     This DNS should never change
    /// </summary>
    public string HardHostname()
    {
        var index = this.Id.IndexOf(RedisConstants.DelimeterId) + 1;

        // this id example: csws.1, or csp.us1
        var instanceId = this.Id[index..]; // example 1
        return $"{instanceId}.{Constants.Domain}".ToLower(); // example 1.ublux.com for a WS. and us1.ublux.com for a pbx
    }

    /// <summary>
    ///     Examples:  
    ///         sft.us1.ublux.com for pbx csp.us1 
    ///         sft.1.ublux.com for WebService csws.1 
    ///     This DNS ip will change when a cloud server is not healthy
    /// </summary>
    public string SoftHostname() => $"sft.{HardHostname()}".ToLower();
}

#endif
