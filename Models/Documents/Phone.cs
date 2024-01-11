// ReSharper disable PropertyCanBeMadeInitOnly.Global
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
    ///     Username and password to login to web-app. Two phones cannot point to the same user.
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(User))]
    public string? IdUser { get; set; }

    ///// <summary>
    /////     Use gateway to make outbound calls. If true gateway to use will be TT.Gateway
    ///// </summary>
    //[AllowUpdate(true)]
    //[Obsolete("gateway")]
    //public bool UseGateway { get; set; }

    #endregion

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
                return _phoneConnectionStatus;
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
                _phoneConnectionStatus = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }
    private PhoneConnectionStatus? _phoneConnectionStatus;

    /// <summary>
    ///     Caller id number that will be used to place outbound calls
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required List<string> CallerIdNumbers { get; set; } = [];

    /// <summary>
    ///     Specifies what caller id to use.  CallerIdIndex cannot be greater than the number of callerIdNumbers.
    /// </summary>
    [AllowUpdate(true)]
    public int CallerIdIndex { get; set; }

    /// <summary>
    ///     Record, transcribe or AI analyse external calls to PSTN. 
    ///     This are only for outgoing calls!
    ///     Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.    
    /// </summary>
    [AllowUpdate(true)]
    public CallProcessingType ProcessingTypeExternal { get; set; }

    /// <summary>
    ///     Record, transcribe or AI analyse internal calls between extensions. 
    ///     This are only for outgoing calls!
    ///     Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.    
    /// </summary>
    [AllowUpdate(true)]
    public CallProcessingType ProcessingTypeInternal { get; set; }

    /// <summary>
    ///     What input to pass to AI engine. If null it should use a default input that is part of constants.
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(AiCallAnalysisInput))]
    public string? IdAiCallAnalysisInput { get; set; }

    /// <summary>
    ///     Language to use when playing messages
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
    ///     Mac address of phone in case it is a physical phone that autoprovision with Ublux.
    ///     NOTE THIS CAN CHANGE IF CONNECTED VIA WIFI AND THEN ETHERNET!
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? MacAddress
    {
        get => macAddress;
        set => macAddress = value is null ? "" : value.Replace(":", "").ToLower();
    }
    private string? macAddress;

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

    /// <summary>
    ///     This is needed for yealink cordless phones for example. Phones on the same group name will be sent as a group when autoprovisioning.
    ///     Can only set if phone is disconnected.
    /// </summary>
    [AllowUpdate(true)]
    public string? GroupName { get; set; }

    /// <summary>
    ///     Send email if phone disconnects to these emails
    /// </summary>
    [References(typeof(Email))]
    [AllowUpdate(true)]
    public List<string> OnDisconnectedNotifyIdsEmails { get; set; } = [];

    /// <summary>
    ///     Send email if phone connects to these emails
    /// </summary>
    [References(typeof(Email))]
    [AllowUpdate(true)]
    public List<string> OnConnectedNotifyIdsEmails { get; set; } = [];
    
    /// <summary>
    ///     Send email if phone connects to these emails
    /// </summary>
    [AllowUpdate(true)]
    public PhoneAdvanceSettings? AdvanceSettings { get; set; } = null;

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }

    #endregion
}

/// <summary>
///     Advanced settings of a phone
/// </summary>
[UsedImplicitly]
public class PhoneAdvanceSettings
{
    /// <summary>
    ///     If a phone is hacked we will only allow connections from this ip address.
    ///     If value is null any ip address will be valid
    /// </summary>
    [AllowUpdate(true)]
    public string? AllowConnectionsFromOnlyThisIp
    {
        get; 
        [UsedImplicitly]
        set;
    }
    
    /// <summary>
    ///     This feature only applies to physical phones. It might only be supported on Yealink phones
    /// </summary>
    [AllowUpdate(true)]
    public bool DisableMissedCallPopup { get; set; } = false;
    
    /// <summary>
    ///     Prevents user from enabling DND on his phone.
    ///     This feature only applies to physical phones. It might only be supported on Yealink phones.
    /// </summary>
    [AllowUpdate(true)]
    public bool DisableDoNotDisturb { get; set; } = false;

    /// <summary>
    ///     Prevents user from changing the volume. Volume value will be from 0 to 5
    ///     This feature only applies to physical phones. It might only be supported on Yealink phones.
    /// </summary>
    [AllowUpdate(true)] 
    public int? DisableRingVolume  { get; set; } = null;

    // Default pin is 24680. Use value of 2
    /// <summary>
    ///     (0-All Keys;1-Function Keys;2-Menu Keys)
    ///     Prevents user from making changes to phone. It will require a pin in order to use phone.
    ///     This feature only applies to physical phones. It might only be supported on Yealink phones.
    /// </summary>
    [AllowUpdate(true)] 
    public int? DisablePhone { get; set; } = null;
}