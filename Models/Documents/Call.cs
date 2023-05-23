namespace Ublux.Communications.Models.Documents;

// IF CALL IS NOT TERMINATED (DURATION IN SECONDS IS NULL) THEN IT CAN ONLY BE UPDATED BY PBX!
// IF CALL IS TERMINATED IT CAN ONLY BE UPDATED BY WS

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
    [UbluxValidationRequired]
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
    ///     NOANSWER: No answer. The dial command reached its number, the number ring for too long, then the dial timed out.
    ///     CANCEL: Call is canceled. The dial command reached its number but the caller hung up before the callee picked up.
    ///     CONGESTION: Congestion. This status is usually a sign that the dialed number is not recognized.
    ///     CHANUNAVAIL: Channel unavailable. On SIP, peer may not be registered.
    /// </summary>
    //     DONTCALL: Privacy mode, callee rejected the call
    //     TORTURE: Privacy mode, callee chose to send caller to torture menu
    //     INVALIDARGS: Error parsing Dial command arguments (added for Asterisk 1.4.1, SVN r53135-53136)
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(50)]
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
    [UbluxValidationRequired]
    [UbluxValidationStringRange(1, 20)]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     Only used on mongo in oder to search fast on queries by index
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string FromReversed
    {
        get
        {
            return From.ReverseString();
        }
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public virtual required CountryIsoCode FromCountry { get; set; }

    /// <summary>
    ///     Phone number called
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(1, 20)]
    public required string To { get; set; } = string.Empty;

    /// <summary>
    ///     Only used on mongo in oder to search fast on queries by index
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string ToReversed
    {
        get
        {
            return To.ReverseString();
        }
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public virtual required CountryIsoCode ToCountry { get; set; }

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
    ///     Processed AI output
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiCallAnalysisOutput? AiCallAnalysisOutput { get; set; }

    /// <summary>
    ///     AI input
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(AiCallAnalysisInput))]
    public string? IdAiCallAnalysisInput { get; set; }

    ///// <summary>
    /////     AI analysis of the call
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public AiCallAnalysis? Analysis { get; set; }

    ///// <summary>
    /////     AI analysis of the call
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public AiCallAnalysis? Analysis2 { get; set; }

    ///// <summary>
    /////     AI analysis of the call
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public AiCallAnalysis? Analysis3 { get; set; }

    /// <summary>
    ///     Lines that participated in this call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Line))]
    public List<string> IdsParticipantLines { get; set; } = new();

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

    ///// <summary>
    /////     If there is an error message with the call.
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[UbluxValidationStringRange(2000)]
    //public string? ErrorMessage { get; set; }

    ///// <summary>
    /////     Add error message to list of errors
    ///// </summary>    
    //public void AddErrorMessage(string message)
    //{
    //    if (this.ErrorMessage is null)
    //    {
    //        this.ErrorMessage = message;
    //    }
    //    else
    //    {
    //        this.ErrorMessage += "\n" + message;
    //    }
    //}

    /// <summary>
    ///     Contain call errors
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(1000)]    
    public CallErrors Errors { get; set; } = new();

    #region ProcessStatus

    /// <summary>
    ///     None if its not being recorded. Remove nullable attribute once done publishing
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public ProcessStatus RecordingStatus { get; set; }

    /// <summary>
    ///     None if it is not going to be AI processed. This is for transcriptions. Converting audio to text.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public ProcessStatus AiTranscriptionStatus { get; set; }

    /// <summary>
    ///     None if it is not going to be AI processed. This is for analysys. ChatGPT performs the analysis of the transcription
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public ProcessStatus AiAnalysisStatus { get; set; }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // we sort calls in descending order; therefore, we pass -1 as the sort order

        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes (we sort calls by descending creation date)
        foreach (var item in base.GetMandatoryIndexes(collection, -1))
            yield return item;

        #region from/to indexes

        /* example on how to execute
         db.Calls.find({
          idAccount: "Ac.1",
          from: { $search: "954654" }
        });
         * */

        // Search by from and id of account
        yield return new MongoDbIndex(collection, nameof(this.FromReversed)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated)); 

        // Search by to and id of account
        yield return new MongoDbIndex(collection, nameof(this.ToReversed)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        #endregion

        // For ougoing calls enable searching fast by line that initiated phone call then by id of account
        yield return new MongoDbIndex(collection, nameof(CallOutgoing.IdLineThatInitiatedCall)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // For incoming calls enable searching fast by the line that answered the call then by id of account
        yield return new MongoDbIndex(collection, nameof(CallIncomingToExtension.IdLineThatAnswered)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // Enable searching fast by the participant lines then by id of account
        yield return new MongoDbIndex(collection, nameof(this.IdsParticipantLines)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // Helps find calls that are ready to be transcribed or ai analyzed
        yield return new MongoDbIndex(collection, nameof(this.RecordingStatus)).Add(nameof(this.AiAnalysisStatus)).Add(nameof(this.AiTranscriptionStatus));

        // Needed to revert status from queued to pending in case app crashes
        yield return new MongoDbIndex(collection, nameof(this.RecordingStatus));
        yield return new MongoDbIndex(collection, nameof(this.AiAnalysisStatus));
        yield return new MongoDbIndex(collection, nameof(this.AiTranscriptionStatus));
    }

    #endregion
}