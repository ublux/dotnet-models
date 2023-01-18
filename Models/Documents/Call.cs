﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux phone call
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlowLogic), nameof(CallType.IncomingToCallFlowLogic))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[BsonKnownTypes(
    typeof(CallIncomingToCallFlowLogic),
    typeof(CallIncomingToExtension),
    typeof(CallOutgoingToExtension),
    typeof(CallOutgoingToPSTN)
)]
public abstract partial class Call : UbluxDocument, ICall, IReferencesTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of voicemail in case there is one
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Voicemail))]
    public string? IdVoicemail { get; set; }

    /// <summary>
    ///     This call was originated with the purpose of tranfering another call with this id    
    ///     When this variable is set the call is marked as completed
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Call))]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer { get; set; }

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Call channel variables. Language, MOH, CallerId etc
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
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
    public required string DialStatus { get; set; }

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
    [IsUbluxRequired]
    public required string From { get; set; }

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required CountryIsoCode FromCountry { get; set; }

    /// <summary>
    ///     Phone number called
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string To { get; set; }

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required CountryIsoCode ToCountry { get; set; }

    /// <summary>
    ///     Type of call
    ///     TODO: Create index on DB
    /// </summary>
    [AllowUpdate(false)]
    public abstract CallType CallType
    {
        get;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set;
    }

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

    /// <inheritdoc />
    [AllowUpdate(false)]
    public DateTime? DateEnded { get; set; }

    /// <summary>
    ///     Result of a call
    /// </summary>
    [AllowUpdate(true)]
    public CallResult CallResult { get; set; }

    /// <summary>
    ///     If there is a language it means there is a transcription
    /// </summary>
    [AllowUpdate(false)]
    public string? TranscriptionLanguage { get; set; }

    /// <summary>
    ///     Audio of agent converted to text
    /// </summary>
    [AllowUpdate(false)]
    public List<AiTranscription> TranscriptionAgent { get; set; } = new();

    /// <summary>
    ///     Audio of client converted to text
    /// </summary>
    [AllowUpdate(false)]
    public List<AiTranscription> TranscriptionClient { get; set; } = new();

    #endregion
}