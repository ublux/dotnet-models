using System.Text.RegularExpressions;

namespace Ublux.Communications.Models;

/// <summary>
///     Application constants
/// </summary>
public static partial class Constants
{
    ///// <summary>
    /////     If a packet contains this we will not mark it as black. Zoiper does not send domain on packets
    ///// </summary>
    //public const string SipPacketLineId = "sip:Li.";

    /// <summary>
    ///     Stun server to use
    /// </summary>
    public const string StunServerDomain = "stun3.l.google.com";
    /// <summary>
    ///     Stun server port to use. Fanvil uses port 3478
    /// </summary>
    public const ushort StunServerPort = 19302;

    /// <summary>
    ///     /usr/share/ublux
    /// </summary>
    public static readonly string PathApp = GetPathApp();
    private static string GetPathApp()
    {
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(appData, "ublux");
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
            return path;
        }
        else
        {
            return "/usr/share/ublux";
        }
    }

    /// <summary>
    ///     Stuff in here can be deleted and app should still be able to work
    ///     /usr/share/ublux/tmp
    /// </summary>
    public static string PathTempUblux()
    {
        var path = Path.Combine(PathApp, "tmp");
        if (__PathTempUblux__HasBeenChecked == false)
        {
            __PathTempUblux__HasBeenChecked = true;
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
        }
        return path;
    }
    private static bool __PathTempUblux__HasBeenChecked = false;

    /// <summary>
    ///     We will send all notification emails from this account
    /// </summary>
    public const string EmailUbluxNoReply = $"no-reply@{Domain}";

    /// <summary>
    ///     Used on footer of emails for example
    /// </summary>
    public const string EmailUbluxSupport = $"support@{Domain}";

    /// <summary>
    ///     Use this DNS on phones
    /// </summary>
    public const string DNS_Primary = "8.8.8.8";

    /// <summary>
    ///     Use this DNS on phones
    /// </summary>
    public const string DNS_Secondary = "8.8.4.4";

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

    ///// <summary>
    /////     Example: sip:Li.1G.Ph.1.1F@189.174.117.130:12013;transport=TLS;x-ast-orig-host=192.168.1.10:12013
    /////     Attempt to get two ip addresses the public and private ip of line
    ///// </summary>
    //[GeneratedRegex("(\\d+\\.\\d+\\.\\d+\\.\\d+)")]
    //public static partial Regex RegexLineContact();

    /// <summary>
    ///     Port used for UDP (only use this for providers)
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

    /// <summary>
    ///     rtpstart on rtp.conf
    /// </summary>
    public const int RtpPortStart = 10_000;
    /// <summary>
    ///     rtpend on rtp.conf
    /// </summary>
    public const int RtpPortEnd = 20_000;

    /// <summary>
    ///     Simple tcp server used on pbx
    /// </summary>
    public const int PortBinaryTcpServer = 8181;

    /// <summary>
    ///     Common actions
    /// </summary>
    private static readonly FlowNodeType[] CommonActions = new[]
    {
        FlowNodeType.Say,
        FlowNodeType.Play,
        FlowNodeType.API,
        FlowNodeType.CallBackAPI,
        FlowNodeType.Bookmark,
        FlowNodeType.GoTo,
        FlowNodeType.Call,
        FlowNodeType.Pause,
        FlowNodeType.Comment,
        FlowNodeType.Hangup,
        FlowNodeType.DynamicExtension,
        FlowNodeType.Extension,

        FlowNodeType.IfLineOffline,
        FlowNodeType.IfDigits,
        FlowNodeType.IfTime
    };

    /// <summary>
    ///     Contains the rules for the type of children each node can have. 
    ///     For example the node IfTime can only have the child Time
    /// </summary>
    public static readonly Dictionary<FlowNodeType, FlowNodeType[]> FlowNodeChildRules = new()
    {
        // Conditionals
        { FlowNodeType.IfLineOffline,
            new FlowNodeType[]{ FlowNodeType.LineOffline, FlowNodeType.LineOnline } },
        { FlowNodeType.IfDigits,
            new FlowNodeType[]{ FlowNodeType.Digits, FlowNodeType.AnyDigits } },
        { FlowNodeType.IfTime,
            new FlowNodeType[]{ FlowNodeType.Time } },

        // Conditional childs
        { FlowNodeType.Time, CommonActions },
        { FlowNodeType.Digits, CommonActions },
        { FlowNodeType.AnyDigits, CommonActions },
        { FlowNodeType.LineOffline, CommonActions },
        { FlowNodeType.LineOnline, CommonActions },
        { FlowNodeType.AnyTime, CommonActions },

        // Rest of children
        { FlowNodeType.Say, CommonActions },
        { FlowNodeType.Play, CommonActions },
        { FlowNodeType.API, CommonActions },
        { FlowNodeType.CallBackAPI, CommonActions },
        { FlowNodeType.Bookmark, CommonActions },
        { FlowNodeType.GoTo, CommonActions },
        { FlowNodeType.Call, CommonActions },
        { FlowNodeType.Pause, CommonActions },
        { FlowNodeType.Comment, CommonActions },
        { FlowNodeType.Hangup, CommonActions },
        { FlowNodeType.DynamicExtension, CommonActions },
        { FlowNodeType.Extension, CommonActions },
    };

    /// <summary>
    ///     Valid characters for an instance id. It cannot contain . it will make method GetLineId from phone not work!
    /// </summary>
    public static readonly HashSet<char> InstanceIdValidChars = new("ABCDEFGHIJKLMNOPQRSTUVWXYZ-0123456789".ToCharArray());

    /// <summary>
    ///     Pbx specific constants
    /// </summary>
    public static class Pbx
    {
        // Initialze before others!!!
        /// <summary>
        ///     Base directory. 
        /// </summary>
        public static readonly string BaseDirPbxFiles = Path.Combine(PathApp, "pbx-files");

        /// <summary>
        ///     Store in array so that when pbx initializes it ensures this directories exist
        /// </summary>
        public static readonly string[] AllPaths = new string[]
        {
            Path.Combine(BaseDirPbxFiles, "completed-calls"),
            Path.Combine(BaseDirPbxFiles, "completed-calls-errors"),
            Path.Combine(BaseDirPbxFiles, "recordings"),
            Path.Combine(BaseDirPbxFiles, "voicemails")
        };

        /// <summary>
        ///     One service is responsible for searching for completed calls and placing them serialized in here
        ///     /usr/share/ublux/pbx-files/recordings/completed-calls
        /// </summary>
        public static readonly string PathCompletedCalls = AllPaths[0];

        /// <summary>
        ///     If a call cannot be uploaded it will be moved to this directory
        ///     /usr/share/ublux/pbx-files/recordings/completed-calls-errors
        /// </summary>
        public static readonly string PathCompletedCallsErrors = AllPaths[1];

        /// <summary>
        ///     Location where to store call recordings. /usr/share/ublux/pbx-files/recordings
        /// </summary>
        public static readonly string PathRecordings = AllPaths[2];

        /// <summary>
        ///     Location where to store call recordings. /usr/share/ublux/pbx-files/voicemails
        /// </summary>
        public static readonly string PathVoicemails = AllPaths[3];
    }
}
