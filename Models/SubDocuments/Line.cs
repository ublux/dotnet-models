namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary>
public partial class Line : UbluxSubDocument
{
    private static readonly ReaderWriterLockSlim _lock = new();

    private LineConnectionStatus? _lineConnectionStatus;

    /// <summary>
    ///     If true it will be sync with WS because line status changed
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    [BsonIgnore]
    [HideForCreateRequest]
    public bool IsConnectionStatusChanged;
   
    /// <summary>
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; } = "";

    /// <summary>
    ///     Line status
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public LineConnectionStatus? LineConnectionStatus
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _lineConnectionStatus;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _lineConnectionStatus = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Caller id number that will be used to place outbound calls
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string CallerIdNumber { get; set; } = "";

    /// <summary>
    ///     Record outbound calls to PSTN?
    /// </summary>
    [AllowUpdate(true)]
    public bool RecordExternalCalls { get; set; }

    /// <summary>
    ///     Record calls to other extensions?
    /// </summary>
    [AllowUpdate(true)]
    public bool RecordInternalCalls { get; set; }

    #region AI

    /// <summary>
    ///     Users will be charged extra for AI transcriptions. If this is true external calls to PSTN will be recorded.
    /// </summary>
    [AllowUpdate(true)]
    public bool UseAiForExternalCalls { get; set; }
    /// <summary>
    ///     Users will be charged extra for AI transcriptions. If this is true internal calls to extensions will be recorded.
    /// </summary>
    [AllowUpdate(true)]
    public bool UseAiForOutgoingCallsToExtensions { get; set; }

    #endregion

    /// <summary>
    ///     Langage to use when playing messages
    /// </summary>
    [AllowUpdate(true)]
    public Language Language { get; set; }

    /// <summary>
    ///     Field used to know when the line received last network traffic packet
    ///     Thanks to this field we can monitor when a phone is disconnected
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    [BsonIgnore]
    [HideForCreateRequest]
    public DateTime DateReceivedLastPacket;

    ///// <summary>
    /////     Used by PBX
    /////     Example: 1.1.1.1.5060
    /////     This is the ip and port that we get from tcpdump captured packets. Note it uses "." instead of ":" to separate the port
    ///// </summary>
    //public string? GetTcpDumpSourceEndpointKey()
    //{
    //    if (this.LineConnectionStatus?.IpWAN is null)
    //        return null;

    //    // Example: 1.1.1.1.5060
    //    return $"{this.LineConnectionStatus.IpWAN}.{this.LineConnectionStatus.PortWAN}";
    //}
}