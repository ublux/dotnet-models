namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux phone call
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlow), nameof(CallType.IncomingToCallFlow))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[BsonKnownTypes(
    typeof(CallIncomingToCallFlow),
    typeof(CallIncomingToExtension),
    typeof(CallOutgoingToExtension),
    typeof(CallOutgoingToPSTN)
)]
public abstract partial class Call : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of voicemail in case there is one
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Voicemail))]
    public string? IdVoicemail { get; set; }

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Call channel variables. Language, MOH, CallerId etc
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required ChannelVariables ChannelVariables { get; set; }

    /// <summary>
    ///     Child calls
    /// </summary>
    [AllowUpdate(false)]
    public List<ChildCall> ChildCalls { get; set; } = new();

    /// <summary>
    ///     If outgoing:
    ///         Contact that we are calling
    ///     If incoming:
    ///         Contact that called us        
    /// </summary>
    [AllowUpdate(false)]
    public abstract Contact? Contact { get; set; }

    #endregion

    /// <summary>
    ///     DateEnded - DateCreated will let you know the duration of call
    /// </summary>
    [AllowUpdate(false)]
    public DateTime? DateEnded { get; set; }

    /// <summary>
    ///     ANSWER: Call is answered. A successful dial. The caller reached the callee.
    ///     BUSY: Busy signal. The dial command reached its number but the number is busy.
    ///     NOANSWER: No answer. The dial command reached its number, the number rang for too long, then the dial timed out.
    ///     CANCEL: Call is canceled. The dial command reached its number but the caller hung up before the callee picked up.
    ///     CONGESTION: Congestion. This status is usually a sign that the dialed number is not recognized.
    ///     CHANUNAVAIL: Channel unavailable. On SIP, peer may not be registered.
    ///     DONTCALL: Privacy mode, callee rejected the call
    ///     TORTURE: Privacy mode, callee chose to send caller to torture menu
    ///     INVALIDARGS: Error parsing Dial command arguments (added for Asterisk 1.4.1, SVN r53135-53136)
    /// </summary>
    [AllowUpdate(false)]
    public DialStatus Status { get; set; }

    /// <summary>
    ///     Number of seconds it took to answer
    /// </summary>
    [AllowUpdate(false)]
    public int? SecondsItTookToAnswer { get; set; }

    /// <summary>
    ///     Dates when call is placed on hold
    /// </summary>
    [AllowUpdate(false)]
    public List<TimeWhenCallPlacedOnHold> TimesWhenCallPlacedOnHold { get; set; } = new();

    /// <summary>
    ///     Caller id
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string From { get; set; }

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required CountryIsoCode FromCountry { get; set; }

    /// <summary>
    ///     Phone number called
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string To { get; set; }

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required CountryIsoCode ToCountry { get; set; }

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    public abstract CallType CallType { get; }

    /// <summary>
    ///     True if call has recording
    /// </summary>
    [AllowUpdate(false)]
    public Recording? Recording { get; set; }

    /// <summary>
    ///     Was video disabled on call?
    /// </summary>
    [AllowUpdate(false)]
    public bool DisabledVideo { get; set; }

    /// <summary>
    ///     List because user can send digits multiple times
    /// </summary>
    [AllowUpdate(false)]
    public List<string> DigitsSent { get; set; } = new();

    /// <summary>
    ///     Is the call international. This is true if any of the child calls is international
    ///     Also note that an incoming call can be international too!
    /// </summary>               
    [AllowUpdate(false)]
    public bool IsInternational { get; set; }

    #endregion
}