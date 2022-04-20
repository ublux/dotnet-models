using JsonSubTypes;

namespace Ublux.Communications.Models.Documents;

// ReSharper disable ConditionIsAlwaysTrueOrFalse
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
public abstract class Call : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;

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
    public ChannelVariables ChannelVariables { get; set; } = new ChannelVariables();

    /// <summary>
    ///     Child calls
    /// </summary>
    [AllowUpdate(false)]
    public List<ChildCall> ChildCalls
    {
        get => _ChildCalls;
        set
        {
            if (value is null) _ChildCalls.Clear();
            else _ChildCalls = value;
        }
    }
    List<ChildCall> _ChildCalls = new();


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
    public string? DateEnded { get; set; }

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
    public string? Status { get; set; }

    /// <summary>
    ///     Number of seconds it took to answer
    /// </summary>
    [AllowUpdate(false)]
    public int? SecondsItTookToAnswer { get; set; }

    /// <summary>
    ///     Dates when call is placed on hold
    /// </summary>
    [AllowUpdate(false)]
    public List<TimeWhenCallPlacedOnHold> TimesWhenCallPlacedOnHold
    {
        get => _TimesWhenCallPlacedOnHold;
        set
        {
            if (value is null) _TimesWhenCallPlacedOnHold.Clear();
            else _TimesWhenCallPlacedOnHold = value;
        }
    }
    List<TimeWhenCallPlacedOnHold> _TimesWhenCallPlacedOnHold = new();

    /// <summary>
    ///     Caller id
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string From { get; set; } = string.Empty;

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public CountryIsoCode FromCountry { get; set; }

    /// <summary>
    ///     Phone number called
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string To { get; set; } = string.Empty;

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public CountryIsoCode ToCountry { get; set; }

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
    public List<string> DigitsSent
    {
        get => _DigitsSent;
        set
        {
            if (value is null) _DigitsSent.Clear();
            else _DigitsSent = value;
        }
    }
    List<string> _DigitsSent = new();

    /// <summary>
    ///     Is the call international. This is true if any of the child calls is international
    ///     Also note that an incoming call can be international too!
    /// </summary>               
    [AllowUpdate(false)]
    public bool IsInternational { get; set; }

    #endregion
}