namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     This specifies to what PBX it will be connected to
    /// </summary>
    [References(typeof(CloudServicePbx))]
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string IdCloudServicePbx { get; set; } = string.Empty;

    /// <summary>
    ///     Configuration phone will use
    /// </summary>
    [References(typeof(PhoneConfiguration))]
    [AllowUpdate(true)]
    public string? IdPhoneConfiguration { get; set; }

    /// <summary>
    ///     Username and password to login to web-app
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(User))]
    public string? IdUser { get; set; }

    #endregion

    #region Line

    //private static readonly ReaderWriterLockSlim _lock = new();

    private PhoneConnectionStatus? _lineConnectionStatus;

    /// <summary>
    ///     If true it will be sync with WS because line status changed
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    [BsonIgnore]
    [HideForCreateRequest]
    public bool IsConnectionStatusChanged;

    /// <summary>
    ///     Phone status
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public PhoneConnectionStatus? PhoneConnectionStatus
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
    [UbluxValidationRequired]
    public required List<string> CallerIdNumbers { get; set; } = new();

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
    /// <summary>
    ///     What input to pass to AI engine. If null it should use a default input that is part of constants.
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(AiCallAnalysisInput))]
    public string? IdAiCallAnalysisInput { get; set; }

    #endregion

    /// <summary>
    ///     Langage to use when playing messages
    /// </summary>
    [AllowUpdate(true)]
    public Language Language { get; set; }

    #endregion

    /// <summary>
    ///     Descriptive name of phone
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     Type of phone. If its of type web and user (username and password) must exist in order for phone to connect.
    /// </summary>
    [AllowUpdate(true)]
    public required PhoneType PhoneType { get; set; }

    /// <summary>
    ///     Disable encryption in case device does not support it
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public bool DisableEncryption { get; set; }

    /// <summary>
    ///     Date when phone downloaded configuration from api.ublux.com in order to connect to Ublux
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateAutoProvision { get; set; }

    ///// <summary>
    /////     Ip address of phone when autoprovisioned
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public string? IpAutoProvision { get; set; }

    /// <summary>
    ///     Mac address of phone in case it is a phisical phone that autoprovisions with Ublux.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? MacAddress { get; set; }

    /// <summary>
    ///     User Agent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(500)]
    public string? UserAgent { get; set; }

    /// <summary>
    ///     Device pin of 5 random digits used to connect phone in case extension is used by multiple phones
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(50)]
    public required string Pin { get; set; } = string.Empty;

    /// <summary>
    ///     TimeZone of this phone
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string TimeZone { get; set; } = "America/New_York";

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }

    /// <summary>
    ///     Ids of phones contain id of phone embeded
    /// </summary>
    public static string GetIdOfAccount(string idPhone)
    {
        // string input = "Ph.Ac.1.WS.1000";

        var start = Phone.DocumentPrefix.Length + Account.DocumentPrefix.Length + 3;

        var thirdDot = start + idPhone[start..].IndexOf(RedisConstants.DelimeterId);

        // id account will be substring in btween dot 1 and
        var idAccount = idPhone[(Phone.DocumentPrefix.Length + 1)..thirdDot];

        return idAccount;
    }

    #endregion
}