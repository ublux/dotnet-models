namespace Ublux.Communications.Models.Documents;

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
public abstract partial class Call : UbluxDocument_ReferenceAccount_ReferenceTags, ICall
{
    #region Properties

    #region References

    // on PBX this will be the full path where voicemail was left. Once call is processed this should be fixed
    /// <summary>
    ///     Id of voicemail in case there is one
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Voicemail))]
    public string? IdVoicemail { get; set; }

    /// <summary>
    ///     This call was originated with the purpose of tranfering another call with this id    
    ///     When this variable is set the call is marked as completed
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Call))]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer { get; set; }

    /// <summary>
    ///     If outgoing:
    ///         Reference of contact that we are calling
    ///     If incoming:
    ///         Reference of of Contact that called us        
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Contact))]
    public string? IdContact { get; set; }

    /// <summary>
    ///     Contact full name    
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactFullName { get; set; }

    /// <summary>
    ///     Refernce to AI call transcription
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(AiCallTranscription))]
    public string? IdAiCallTranscription { get; set; }

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Call channel variables. Language, MOH, CallerId etc
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required ChannelVariables ChannelVariables { get; set; }

    /// <summary>
    ///     Child calls
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<ChildCall> ChildCalls { get; set; } = new();

    #endregion

    /// <summary>
    ///     ANSWER: Call is answered. A successful dial. The caller reached the callee.
    ///     BUSY: Busy signal. The dial command reached its number but the number is busy.
    ///     NOANSWER: No answer. The dial command reached its number, the number rang for too long, then the dial timed out.
    ///     CANCEL: Call is canceled. The dial command reached its number but the caller hung up before the callee picked up.
    ///     CONGESTION: Congestion. This status is usually a sign that the dialed number is not recognized.
    ///     CHANUNAVAIL: Channel unavailable. On SIP, peer may not be registered.
    /// </summary>
    //     DONTCALL: Privacy mode, callee rejected the call
    //     TORTURE: Privacy mode, callee chose to send caller to torture menu
    //     INVALIDARGS: Error parsing Dial command arguments (added for Asterisk 1.4.1, SVN r53135-53136)
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string DialStatus { get; set; } = string.Empty;

    /// <summary>
    ///     Number of seconds it took to answer
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? SecondsItTookToAnswer { get; set; }

    /// <summary>
    ///     Dates when call is placed on hold
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<TimeWhenCallPlacedOnHold> TimesWhenCallPlacedOnHold { get; set; } = new();

    /// <summary>
    ///     Caller id
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required CountryIsoCode FromCountry { get; set; }

    /// <summary>
    ///     Phone number called
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string To { get; set; } = string.Empty;

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required CountryIsoCode ToCountry { get; set; }

    /// <summary>
    ///     Type of call
    ///     TODO: Create index on DB
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public abstract CallType CallType
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    }

    /// <summary>
    ///     True if call has recording
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public Recording? Recording { get; set; }

    /// <summary>
    ///     Was video disabled on call?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public bool DisabledVideo { get; set; }

    /// <summary>
    ///     List because user can send digits multiple times
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> DigitsSent { get; set; } = new();

    /// <summary>
    ///     Is call international. This does not include child calls.
    /// </summary>               
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required bool IsInternational { get; set; }

    /// <summary>
    ///     True if it contains any child call or master call international
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public bool ContainsInternationalCall
    {
        get
        {
            if (this.IsInternational)
                return true;

            if (this.ChildCalls is null)
                return false;

            return this.ChildCalls.Any(x => x.IsInternational);
        }
#if UBLUX_Release || RELEASE
        set { }
#endif        
    }

    ///// <inheritdoc />
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public DateTime? DateEnded { get; set; }

    /// <summary>
    ///     Result of a call
    /// </summary>
    [AllowUpdate(true)]
    public CallResult CallResult { get; set; }

    /// <summary>
    ///     AI analysis of the call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiAnalysis? Analysis { get; set; }

    /// <summary>
    ///     AI analysis of the call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiAnalysis? Analysis2 { get; set; }

    /// <summary>
    ///     AI analysis of the call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiAnalysis? Analysis3 { get; set; }

    /// <summary>
    ///     Lines that participated in this call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> ParticipantLines { get; set; } = new();

    /// <summary>
    ///     If not null it means the call is ended
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? DurationInSeconds { get; set; }

    ///// <summary>
    /////     Returns -1 if call has not completed
    /////     Returns -2 if date started is larger than date ended
    ///// </summary>
    //public double GetDurationInSeconds()
    //{
    //    if (this.DateEnded.HasValue == false) return -1;
    //    if (this.DateEnded < this.DateCreated) return -2;
    //    return (this.DateEnded.Value - this.DateCreated).TotalSeconds;
    //}

    #endregion

    /// <summary>
    ///     If there is an error message with the call.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     Add error message to list of errors
    /// </summary>
    public void AddErrorMessage(string message)
    {
        if(this.ErrorMessage is null)
        {
            this.ErrorMessage = message; 
        }
        else
        {
            this.ErrorMessage += "\n" + message;
        }
    }

    /// <summary>
    ///     Null if it is not going to be AI processed. This is for transcriptions. Converting audio to text.
    ///     TODO: create index
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiProcessStatus AiTranscriptionStatus { get;set; }

    /// <summary>
    ///     Null if it is not going to be AI processed. This is for analysys. ChatGPT performs the analysis of the transcription
    ///     TODO: create index
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiProcessStatus AiAnalysisStatus { get; set; }
}