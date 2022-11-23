using System.Text.RegularExpressions;

namespace Ublux.Communications.Models;

/// <summary>
///     Application constants
/// </summary>
public static partial class Constants
{
    /// <summary>
    ///     If a packet contains this we will not mark it as black. Zoiper does not send domain on packets
    /// </summary>
    public const string SipPacketLineId = "sip:Li.";

    /// <summary>
    ///     Domain for application
    /// </summary>
    public const string Domain = "ublux.com";

    /// <summary>
    ///     Example: api.ublux.com
    /// </summary>
    public const string WebService_HostName = $"api.{Domain}";

    /// <summary>
    ///     Example: https://api.ublux.com
    /// </summary>
    public const string WebService_BaseUrl = $"https://{WebService_HostName}";

    /// <summary>
    ///     Regex used to find ip address V4 and port
    /// </summary>
    [GeneratedRegex("(\\d+\\.\\d+\\.\\d+\\.\\d+):(\\d+)")]
    public static partial Regex RegexIpAndPort();

    /// <summary>
    ///     Regex used to find ip address V4
    /// </summary>
    [GeneratedRegex("(\\d+\\.\\d+\\.\\d+\\.\\d+)")]
    public static partial Regex RegexIp();


    /// <summary>
    ///     Example: sip:Li.1G.Ph.1.1F@189.174.117.130:12013;transport=TLS;x-ast-orig-host=192.168.1.10:12013
    ///     Attempt to get two ip addresses the public and private ip of line
    /// </summary>
    [GeneratedRegex("(\\d+\\.\\d+\\.\\d+\\.\\d+)")]
    public static partial Regex RegexLineContact();


    /// <summary>
    ///     Port used for UDP
    /// </summary>
    public const int AsteriskPortUdp = 5060;
    /// <summary>
    ///     Port used by asterisk on TCP
    /// </summary>
    public const int AsteriskPortTcp = 5060;

    /// <summary>
    ///     Port used for encrypted asterisk connections
    /// </summary>
    public const int AsteriskPortTls = 5061;

    /// <summary>
    ///     Port used for web phones
    /// </summary>
    public const int AsteriskPortWss = 8089;
}
