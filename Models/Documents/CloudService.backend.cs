﻿#if UBLUX_BACKEND

using System.Net;

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
    public string HostNameHard() => HostNameHard(this.InstanceId);

    /// <summary>
    ///     Examples:  
    ///         sft.us1.ublux.com for pbx csp.us1 
    ///         sft.1.ublux.com for WebService csws.1 
    ///     This DNS ip will change when a cloud server is not healthy
    /// </summary>
    public string HostNameSoft() => HostNameSoft(this.InstanceId);


    /// <summary>
    ///     Examples:  
    ///         us1.ublux.com for csp.us1 pbx
    ///         1.ublux.com for csws.1 web service
    ///     This DNS should never change
    /// </summary>
    public static string HostNameHard(string instanceId)
    {
        return $"{instanceId}.{Constants.Domain}".ToLower();
    }

    /// <summary>
    ///     Examples:  
    ///         sft.us1.ublux.com for pbx csp.us1 
    ///         sft.1.ublux.com for WebService csws.1 
    ///     This DNS ip will change when a cloud server is not healthy
    /// </summary>
    public static string HostNameSoft(string instanceId) => $"sft.{HostNameHard(instanceId)}";    
}

#endif
