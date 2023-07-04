using System.Text.RegularExpressions;
#pragma warning disable CA2211 // Non-constant fields should not be visible

namespace Ublux.Communications.Models;

/// <summary>
///     Application constants
/// </summary>
public static partial class Constants
{
    /// <summary> Amazon Web Services </summary>
    public static class AWS
    {
        /// <summary> S3 storage service </summary>
        public static class S3
        {
            /// <summary> AWS S3 bucket name </summary>
            public static string BucketName = "ws.ublux.com";

            /// <summary> Region of S3 bucket</summary>
            public static Amazon.RegionEndpoint Region = Amazon.RegionEndpoint.USEast1;
        }
    }

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
    ///     Domain where phones do autoprovision
    /// </summary>
    public const string DomainAutoprovision = $"ap.{Domain}";

    /// <summary>
    ///     Example: api.ublux.com
    /// </summary>
    public const string WebService_HostName = $"api.{Domain}";

    /// <summary>
    ///     Example: https://api.ublux.com
    /// </summary>
    public const string WebService_BaseUrl = $"https://{WebService_HostName}";

    /// <summary>
    ///     Example: https://events.ublux.com
    /// </summary>
    public const string WebService_Events = $"events.{Domain}";

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

        FlowNodeType.IfPhoneDisconnected,
        FlowNodeType.IfDigits,
        FlowNodeType.IfTime,
        FlowNodeType.IfWeekDay,
        FlowNodeType.IfDialStatus
    };

#warning create unit test to check that all nodes exist on dictionary!!!!!!!!!!!!!!!!!!!!!!

    /// <summary>
    ///     Contains the rules for the type of children each node can have. 
    ///     For example the node IfTime can only have the child Time
    /// </summary>
    public static readonly Dictionary<FlowNodeType, FlowNodeType[]> FlowNodeChildRules = new()
    {
        // Conditionals
        { FlowNodeType.IfPhoneDisconnected,
            new FlowNodeType[]{ FlowNodeType.PhoneDisconnected, FlowNodeType.PhoneConnected } },
        { FlowNodeType.IfDigits,
            new FlowNodeType[]{ FlowNodeType.Digits, FlowNodeType.AnyDigits } },
        { FlowNodeType.IfTime,
            new FlowNodeType[]{ FlowNodeType.Time, FlowNodeType.AnyTime } },
        { FlowNodeType.IfWeekDay,
            new FlowNodeType[]{ FlowNodeType.WeekDays, FlowNodeType.AnyWeekDay } },
        { FlowNodeType.IfDialStatus,
            new FlowNodeType[]{ FlowNodeType.DialStatus, FlowNodeType.AnyDialStatus } },

        // Childs of conditionals
        { FlowNodeType.Digits, CommonActions },
        { FlowNodeType.AnyDigits, CommonActions },
        { FlowNodeType.PhoneDisconnected, CommonActions },
        { FlowNodeType.PhoneConnected, CommonActions },
        { FlowNodeType.Time, CommonActions },
        { FlowNodeType.AnyTime, CommonActions },
        { FlowNodeType.WeekDays, CommonActions },
        { FlowNodeType.AnyWeekDay, CommonActions },
        { FlowNodeType.DialStatus, CommonActions },
        { FlowNodeType.AnyDialStatus, CommonActions },

#warning implement rest of this nodes

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
    ///     Valid characters for an instance id. It cannot contain . it will make method GetPhoneId from phone not work!
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
            Path.Combine(BaseDirPbxFiles, "voicemails"),
            Path.Combine(BaseDirPbxFiles, "audios"),
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

        /// <summary>
        ///     Location where to store call recordings. /usr/share/ublux/pbx-files/audios
        /// </summary>
        public static readonly string PathAudios = AllPaths[4];
    }

    /// <summary>
    ///     100 Random names
    /// </summary>
    public static readonly string[] RandomNames = new string[]
    {
        "Emma Johnson",
        "Ethan Mitchell",
        "Ava Davis",
        "Logan Martin",
        "Isabella Rodriguez",
        "Benjamin Wright",
        "Sophia Hall",
        "Mason Lee",
        "Mia Adams",
        "Noah Perez",
        "Amelia Turner",
        "William Baker",
        "Harper Nelson",
        "Liam King",
        "Abigail Gonzalez",
        "Owen Cooper",
        "Charlotte Collins",
        "Lucas Smith",
        "Scarlett Ramirez",
        "Samuel Green",
        "Madison Parker",
        "Jackson Hernandez",
        "Lily Peterson",
        "Daniel Wood",
        "Grace Foster",
        "Caleb Stewart",
        "Elizabeth Phillips",
        "Oliver Foster",
        "Emily Ross",
        "Henry Alexander",
        "Chloe Powell",
        "Michael Carter",
        "Victoria Campbell",
        "Gabriel Rivera",
        "Natalie Torres",
        "Andrew Fisher",
        "Addison Gray",
        "Isaac Reyes",
        "Aria West",
        "Jacob Mitchell",
        "Hailey James",
        "Ryan Hill",
        "Aubrey Watson",
        "David Flores",
        "Zoey Cox",
        "Levi Ortiz",
        "Eleanor Parker",
        "Alexander Ramirez",
        "Peyton Mitchell",
        "Benjamin Evans",
        "Ava Gibson",
        "Ethan Young",
        "Mia Foster",
        "Noah Thomas",
        "Isabella Collins",
        "Owen Davis",
        "Charlotte Reed",
        "William Cooper",
        "Harper Cook",
        "Liam Perez",
        "Abigail Bell",
        "Lucas Scott",
        "Scarlett Sanchez",
        "Samuel Morris",
        "Madison Adams",
        "Jackson James",
        "Lily Turner",
        "Daniel Brown",
        "Grace Edwards",
        "Caleb Parker",
        "Elizabeth Flores",
        "Oliver Price",
        "Emily Bailey",
        "Henry Powell",
        "Chloe Collins",
        "Michael Lee",
        "Victoria Wright",
        "Gabriel Rivera",
        "Natalie Reed",
        "Andrew Ortiz",
        "Addison Martin",
        "Isaac Cooper",
        "Aria Taylor",
        "Jacob Rodriguez",
        "Hailey Foster",
        "Ryan Cook",
        "Aubrey Campbell",
        "David Garcia",
        "Zoey Cooper",
        "Levi Torres",
        "Eleanor Wright",
        "Alexander Johnson",
        "Peyton Reed",
        "Benjamin Parker",
        "Ava Young",
        "Ethan Bell",
        "Mia Rodriguez",
        "Noah Scott",
        "Isabella Davis",
        "Owen Collins"
    };

    /// <summary>
    ///     Timezones ordered
    /// </summary>
    public static KeyValuePair<string, string>[] TimeZonesOrdered = new KeyValuePair<string, string>[]  {
            new ("Pacific/Apia", "(UTC-11:00) Midway Island, Samoa"),
            new ("Pacific/Honolulu", "(UTC-10:00) Hawaii"),
            new ("America/Anchorage", "(UTC-09:00) Alaska"),
            new ("America/Los_Angeles", "(UTC-08:00) Pacific Time (US and Canada); Tijuana"),
            new ("America/Denver", "(UTC-07:00) Mountain Time (US and Canada)"),
            new ("America/Chicago", "(UTC-06:00) Central Time (US and Canada)"),
            new ("America/Regina", "(UTC-06:00) Saskatchewan"),
            new ("America/Mexico_City", "(UTC-06:00) Guadalajara, Mexico City, Monterrey"),
            new ("America/New_York", "(UTC-05:00) Eastern Time (US and Canada)"),
            new ("America/Caracas", "(UTC-04:30) Caracas"),
            new ("America/Halifax", "(UTC-04:00) Atlantic Time (Canada)"),
            new ("America/La_Paz", "(UTC-04:00) Georgetown, La Paz, San Juan"),
            new ("America/Santiago", "(UTC-04:00) Santiago"),
            new ("America/Cuiaba", "(UTC-04:00) Manaus"),
            new ("America/Asuncion", "(UTC-04:00) Asuncion"),
            new ("America/Sao_Paulo", "(UTC-03:00) Brasilia"),
            new ("America/Cayenne", "(UTC-03:00) Georgetown"),
            new ("America/Godthab", "(UTC-03:00) Greenland"),
            new ("America/Montevideo", "(UTC-03:00) Montevideo"),
            new ("America/Buenos_Aires", "(UTC-03:00) Buenos Aires"),
            new ("Asia/Baku", "(UTC-03:00) Buenos Aires"),
            new ("Atlantic/Azores", "(UTC-01:00) Azores"),
            new ("Atlantic/Cape_Verde", "(UTC-01:00) Cape Verde Islands"),
            new ("Etc/GMT", "(UTC) Coordinated Universal Time"),
            new ("Europe/Budapest", "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague"),
            new ("Europe/Warsaw", "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb"),
            new ("Europe/Paris", "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris"),
            new ("Europe/Berlin", "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna"),
            new ("Africa/Lagos", "(UTC+01:00) West Central Africa"),
            new ("Europe/Chisinau", "(UTC+02:00) Minsk"),
            new ("Africa/Cairo", "(UTC+02:00) Cairo"),
            new ("Europe/Kiev", "(UTC+02:00) Helsinki, Kiev, Riga, Sofia, Tallinn, Vilnius"),
            new ("Europe/Bucharest", "(UTC+02:00) Athens, Bucharest, Istanbul"),
            new ("Asia/Jerusalem", "(UTC+02:00) Jerusalem"),
            new ("Asia/Beirut", "(UTC+02:00) Beirut"),
            new ("Africa/Johannesburg", "(UTC+02:00) Harare, Pretoria"),
            new ("Europe/Moscow", "(UTC+03:00) Moscow, St. Petersburg, Volgograd"),
            new ("Asia/Tbilisi", "(UTC+03:00) Tbilisi"),
            new ("Asia/Riyadh", "(UTC+03:00) Kuwait, Riyadh"),
            new ("Africa/Nairobi", "(UTC+03:00) Nairobi"),
            new ("Asia/Baghdad", "(UTC+03:00) Baghdad"),
            new ("Asia/Tehran", "(UTC+03:30) Tehran"),
            new ("Asia/Dubai", "(UTC+04:00) Abu Dhabi, Muscat"),
            new ("Asia/Yerevan", "(UTC+04:00) Baku, Tbilisi, Yerevan"),
            new ("Indian/Mauritius", "(UTC+04:00) Port Louis"),
            new ("Asia/Kabul", "(UTC+04:30) Kabul"),
            new ("Asia/Yekaterinburg", "(UTC+05:00) Ekaterinburg"),
            new ("Asia/Tashkent", "(UTC+05:00) Tashkent"),
            new ("Asia/Karachi", "(UTC+05:00) Islamabad, Karachi"),
            new ("Asia/Calcutta", "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi"),
            new ("Asia/Katmandu", "(UTC+05:45) Kathmandu"),
            new ("Asia/Almaty", "(UTC+06:00) Astana, Dhaka"),
            new ("Asia/Colombo", "(UTC+06:00) Sri Jayawardenepura"),
            new ("Asia/Novosibirsk", "(UTC+06:00) Almaty, Novosibirsk"),
            new ("Asia/Rangoon", "(UTC+06:30) Yangon (Rangoon)"),
            new ("Asia/Bangkok", "(UTC+07:00) Bangkok, Hanoi, Jakarta"),
            new ("Asia/Krasnoyarsk", "(UTC+07:00) Krasnoyarsk"),
            new ("Asia/Shanghai", "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi"),
            new ("Asia/Singapore", "(UTC+08:00) Kuala Lumpur, Singapore"),
            new ("Asia/Taipei", "(UTC+08:00) Taipei"),
            new ("Australia/Perth", "(UTC+08:00) Perth"),
            new ("Asia/Irkutsk", "(UTC+08:00) Irkutsk, Ulaanbaatar"),
            new ("Asia/Seoul", "(UTC+09:00) Seoul"),
            new ("Asia/Tokyo", "(UTC+09:00) Osaka, Sapporo, Tokyo"),
            new ("Asia/Yakutsk", "(UTC+09:00) Yakutsk"),
            new ("Australia/Darwin", "(UTC+09:30) Darwin"),
            new ("Australia/Adelaide", "(UTC+09:30) Adelaide"),
            new ("Australia/Sydney", "(UTC+10:00) Canberra, Melbourne, Sydney"),
            new ("Australia/Brisbane", "(UTC+10:00) Brisbane"),
            new ("Australia/Hobart", "(UTC+10:00) Hobart"),
            new ("Asia/Vladivostok", "(UTC+10:00) Vladivostok"),
            new ("Pacific/Port_Moresby", "(UTC+10:00) Guam, Port Moresby"),
            new ("Pacific/Guadalcanal", "(UTC+11:00) Magadan, Solomon Islands, New Caledonia"),
            new ("Pacific/Auckland", "(UTC+12:00) Auckland, Wellington"),
            new ("Asia/Kamchatka", "(UTC+12:00) Petropavlovsk-Kamchatsky"),
            new ("Pacific/Tongatapu", "(UTC+13:00) Nuku'alofa")
        };

    /// <summary>
    ///     Timezone dictionary to search faster
    /// </summary>
    public static Dictionary<string, string> TimeZonesFast = new(TimeZonesOrdered);


}
