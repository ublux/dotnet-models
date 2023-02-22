#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Base class for cloud services
/// </summary>
public abstract partial class CloudService : UbluxDocument
{
    /// <summary>
    ///     We need instance id in order to reboot cloud service for example. Example: i-0655b45b8134e6425 
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(true)]
    public string? ProviderInstanceId { get; set; }

    /// <summary>
    ///     Region is needed to connect to EC2 instance when using AWS for example: USEast1 or EUWest3 for europe paris
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(true)]
    public string? ProviderRegion { get; set; }

    /// <summary>
    ///     Example AWS for amazon web services
    /// </summary>
    [IsUbluxRequired]
    [IgnoreDataMember]
    [AllowUpdate(true)]
    public required CloudServiceProviderType ProviderType { get; set; }

    /// <summary>
    ///     Examples:  
    ///         us1.ublux.com for csp.us1 pbx
    ///         1.ublux.com for csws.1 web service
    ///     This DNS should never change
    /// </summary>
    public string HostNameHard() => HostNameHard(this.InstanceId).ToLower();

    /// <summary>
    ///     Examples:  
    ///         sft.us1.ublux.com for pbx csp.us1 
    ///         sft.1.ublux.com for WebService csws.1 
    ///     This DNS ip will change when a cloud server is not healthy
    /// </summary>
    public string HostNameSoft() => HostNameSoft(this.InstanceId).ToLower();

    /// <summary>
    ///     Examples:  
    ///         us1.ublux.com for csp.us1 pbx
    ///         1.ublux.com for csws.1 web service
    ///     This DNS should never change
    /// </summary>
    public static string HostNameHard(string instanceId) => $"{instanceId}.{Constants.Domain}".ToLower();

    /// <summary>
    ///     Examples:  
    ///         sft.us1.ublux.com for pbx csp.us1 
    ///         sft.1.ublux.com for WebService csws.1 
    ///     This DNS ip will change when a cloud server is not healthy
    /// </summary>
    public static string HostNameSoft(string instanceId) => $"sft.{HostNameHard(instanceId)}".ToLower();

    /// <summary>
    ///     Example: pbx-us-1
    /// </summary>
    public static string BuildInstanceId(CloudServiceType cloudServiceType, int number, CountryIsoCode country)
    {
        return $"{cloudServiceType}-{country}-{number}".ToUpper();
    }

    /// <summary>
    ///     Example: pbx-us-f
    /// </summary>
    public static string BuildInstanceIdFailover(CloudServiceType cloudServiceType, CountryIsoCode country)
    {
        return $"{cloudServiceType}-{country}-F".ToUpper();
    }

    /// <summary>
    ///     Example: pbx-us-f
    /// </summary>
    public static string BuildInstanceIdTest(CloudServiceType cloudServiceType, CountryIsoCode country)
    {
        return $"{cloudServiceType}-{country}-T".ToUpper();
    }
}

#endif
