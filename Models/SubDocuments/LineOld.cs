﻿//namespace Ublux.Communications.Models.SubDocuments;

///// <summary>
/////     It is part of a phone. Phones are needed in order to make and receive phone calls.
///// </summary>
//public partial class LineOld : UbluxSubDocument
//{
//    private static readonly ReaderWriterLockSlim _lock = new();

//    private PhoneConnectionStatus? _lineConnectionStatus;

//    /// <summary>
//    ///     If true it will be sync with API because line status changed
//    /// </summary>
//    [System.Text.Json.Serialization.JsonIgnore]
//    [JsonIgnore]
//    [BsonIgnore]
//    [HideForCreateRequest]
//    public bool IsConnectionStatusChanged;    
   
//    /// <summary>
//    /// </summary>
//    [AllowUpdate(true)]
//    [UbluxValidationRequired]
//    public required string FriendlyName { get; set; } = "";

//    /// <summary>
//    ///     Phone status
//    /// </summary>
//    [AllowUpdate(false)]
//    [SwaggerSchema(ReadOnly = true)]
//    [HideForCreateRequest]
//    public PhoneConnectionStatus? PhoneConnectionStatus
//    {
//        get
//        {
//            _lock.EnterReadLock();
//            try
//            {
//                return _lineConnectionStatus;
//            }
//            finally
//            {
//                _lock.ExitReadLock();
//            }
//        }
//        set
//        {
//            _lock.EnterWriteLock();
//            try
//            {
//                _lineConnectionStatus = value;
//            }
//            finally
//            {
//                _lock.ExitWriteLock();
//            }
//        }
//    }

//    /// <summary>
//    ///     Caller id number that will be used to place outbound calls
//    /// </summary>
//    [AllowUpdate(true)]
//    [UbluxValidationRequired]
//    public required string CallerIdNumber { get; set; } = "";

//    /// <summary>
//    ///     Record outbound calls to PSTN?
//    /// </summary>
//    [AllowUpdate(true)]
//    public bool RecordExternalCalls { get; set; }

//    /// <summary>
//    ///     Record calls to other extensions?
//    /// </summary>
//    [AllowUpdate(true)]
//    public bool RecordInternalCalls { get; set; }

//    #region AI

//    /// <summary>
//    ///     Users will be charged extra for AI transcriptions. If this is true external calls to PSTN will be recorded.
//    /// </summary>
//    [AllowUpdate(true)]
//    public bool UseAiForExternalCalls { get; set; }
//    /// <summary>
//    ///     Users will be charged extra for AI transcriptions. If this is true internal calls to extensions will be recorded.
//    /// </summary>
//    [AllowUpdate(true)]
//    public bool UseAiForOutgoingCallsToExtensions { get; set; }
//    /// <summary>
//    ///     What input to pass to AI engine. If null it should use a default input that is part of constants.
//    /// </summary>
//    [AllowUpdate(true)]
//    [References(typeof(AiCallAnalysisInput))]
//    public string? IdAiCallAnalysisInput { get; set; }

//    #endregion

//    /// <summary>
//    ///     Language to use when playing messages
//    /// </summary>
//    [AllowUpdate(true)]
//    public Language Language { get; set; }

//    ///// <summary>
//    /////     Field used to know when the line received last network traffic packet
//    /////     Thanks to this field we can monitor when a phone is disconnected
//    ///// </summary>
//    //[System.Text.Json.Serialization.JsonIgnore]
//    //[JsonIgnore]
//    //[BsonIgnore]
//    //[HideForCreateRequest]
//    //public DateTime DateReceivedLastPacket;

//    ///// <summary>
//    /////     Used by PBX
//    /////     Example: 1.1.1.1.5060
//    /////     This is the ip and port that we get from tcpdump captured packets. Note it uses "." instead of ":" to separate the port
//    ///// </summary>
//    //public string? GetTcpDumpSourceEndpointKey()
//    //{
//    //    if (this.PhoneConnectionStatus?.IpWAN is null)
//    //        return null;

//    //    // Example: 1.1.1.1.5060
//    //    return $"{this.PhoneConnectionStatus.IpWAN}.{this.PhoneConnectionStatus.PortWAN}";
//    //}
//}