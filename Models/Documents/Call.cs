using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;

namespace Ublux.Communications.Models.Documents;

// IF CALL IS NOT TERMINATED (DURATION IN SECONDS IS NULL) THEN IT CAN ONLY BE UPDATED BY PBX!
// IF CALL IS TERMINATED IT CAN ONLY BE UPDATED BY API

/// <summary>
///     Ublux phone call
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlowLogic), nameof(CallType.IncomingToCallFlowLogic))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPowerDialer), nameof(CallType.PowerDialer))]
[BsonKnownTypes(
    typeof(CallIncomingToCallFlowLogic),
    typeof(CallIncomingToExtension),
    typeof(CallOutgoingToExtension),
    typeof(CallOutgoingToPSTN),
    typeof(CallOutgoingToPowerDialer)
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
    ///     This call was originated with the purpose of transfer another call with this id    
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
    ///     Reference to AI call transcription
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
    public List<ChildCall> ChildCalls { get; set; } = [];

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
    public required DialStatus DialStatus { get; set; }

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
    public List<TimeWhenCallPlacedOnHold> TimesWhenCallPlacedOnHold { get; set; } = [];

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
    [SuppressMessage("Resharper","ValueParameterNotUsed")]
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
    // [UbluxValidationRequired]
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
        // ReSharper disable ValueParameterNotUsed
#else
#endif
    }

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    // [UbluxValidationRequired]
    public virtual required CountryIsoCode ToCountry { get; set; }

    /// <summary>
    ///     Type of call
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
    public List<string> DigitsSent { get; set; } = [];

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
            return IsInternational || ChildCalls.Any(x => x.IsInternational);
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
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public CallResult CallResult { get; set; }

    /// <summary>
    ///     Processed AI output
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiCallAnalysisOutput? AiCallAnalysisOutput { get; set; }

    ///// <summary>
    /////     Processed AI output
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[Obsolete("delete")]
    //public AiCallAnalysisOutput? AiCallAnalysisOutput { get; set; }

    /// <summary>
    ///     AI input
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(AiCallAnalysisInput))]
    public string? IdAiCallAnalysisInput { get; set; }   

    /// <summary>
    ///     Phones that participated in this call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Phone))]
    // ReSharper disable once PropertyCanBeMadeInitOnly.Global
    public ConcurrentBag<string> IdsParticipantPhones { get; set; } = [];


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
    ///     Custom Variables. 
    ///     key = variable name
    ///     value = variable value in json format. It can also be a json array
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public ConcurrentBag<CallVariable> Variables { get; set; } = [];

    /// <summary>
    ///     Given a json object get a specific path. Example: prop1.items[0].firstName
    /// </summary>
    public static string? GetJsonPropertyByPath(string json, string path)
    {
        if (string.IsNullOrEmpty(path) || path == ".")
            return json;

        try
        {
            var propertyNames = path.Split('.');
            JToken currentToken;

            // Check if the JSON string represents an array or an object
            if (json.TrimStart().StartsWith("["))
            {
                var jsonArray = JArray.Parse(json);
                currentToken = jsonArray;
            }
            else
            {
                var jsonObject = JObject.Parse(json);
                currentToken = jsonObject;
            }

            foreach (var propName in propertyNames)
            {
                var start = propName.IndexOf('[');

                if (start >= 0) // Check if propName is an array access e.g. items[1]. Or [1]
                {
                    var end = propName.IndexOf(']');

                    var propNameWithNoIndex = propName[..start];
                    var indexTemp = propName[(start + 1)..end];
                    int.TryParse(indexTemp, out var index);

                    JArray jArray;
                    if (string.IsNullOrEmpty(propNameWithNoIndex) == false)
                    {
                        if (currentToken is JObject jObject)
                        {
                            if (jObject[propNameWithNoIndex] is JArray ja)
                            {
                                jArray = ja;
                            }
                            else
                            {
                                // error
                                return null;
                            }
                        }
                        else
                        {
                            // error
                            return null;
                        }
                    }
                    else
                    {
                        if (currentToken is JArray ja)
                        {
                            jArray = ja;
                        }
                        else
                        {
                            // error
                            return null;
                        }
                    }

                    if (index > jArray.Count)
                    {
                        // error
                        return null;
                    }

                    currentToken = jArray[index];
                }
                else
                {
                    if (currentToken is JObject jObject)
                    {
                        if (jObject.TryGetValue(propName, out var val))
                        {
                            currentToken = val;
                        }
                        else
                        {
                            // error
                            return null;
                        }
                    }
                    else
                    {
                        // error 
                        return null;
                    }
                }
            }

            return currentToken.ToString();
        }
        catch
        {
            return null;
        }

    }

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
    ///     None if it is not going to be AI processed. This is for analysis. ChatGPT performs the analysis of the transcription
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
        var collection = GetType().GetCollectionUsedByType();

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
        yield return new MongoDbIndex(collection, nameof(FromReversed)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // Search by to and id of account
        yield return new MongoDbIndex(collection, nameof(ToReversed)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        #endregion

        // For outgoing calls enable searching fast by line that initiated phone call then by id of account
        yield return new MongoDbIndex(collection, nameof(CallOutgoing.IdPhoneThatInitiatedCall)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // For incoming calls enable searching fast by the line that answered the call then by id of account
        yield return new MongoDbIndex(collection, nameof(CallIncomingToExtension.IdPhoneThatAnswered)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // Enable searching fast by the participant lines then by id of account
        yield return new MongoDbIndex(collection, nameof(IdsParticipantPhones)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // Helps find calls that are ready to be transcribed or ai analyzed
        yield return new MongoDbIndex(collection, nameof(RecordingStatus)).Add(nameof(AiAnalysisStatus)).Add(nameof(AiTranscriptionStatus));

        // Needed to revert status from queued to pending in case app crashes
        yield return new MongoDbIndex(collection, nameof(RecordingStatus));
        yield return new MongoDbIndex(collection, nameof(AiAnalysisStatus));
        yield return new MongoDbIndex(collection, nameof(AiTranscriptionStatus));
    }

    #endregion
}




///// <summary>
/////     AI output of analyzed call
///// </summary>
//public class AiCallAnalysisOutput
//{
//    /// <summary>
//    ///     What input was passed to get this output?
//    /// </summary>
//    [UbluxValidationRequired]
//    [References(typeof(AiCallAnalysisInput))]
//    [AllowUpdate(false)]
//    [SwaggerSchema(ReadOnly = true)]
//    public required string IdAiCallAnalysisInput { get; set; } = "";

//    /// <summary>
//    ///     Detected language on call conversation
//    /// </summary>    
//    [AllowUpdate(false)]
//    [SwaggerSchema(ReadOnly = true)]
//    public required string DetectedLanguage { get; set; }


//    /// <summary>
//    ///     Total tokes used by AI engine
//    /// </summary>    
//    [AllowUpdate(false)]
//    [SwaggerSchema(ReadOnly = true)]
//    public int TokensTotal { get; set; }

//    /// <summary>
//    ///     Tokens used by completion on AI engine
//    /// </summary>    
//    [AllowUpdate(false)]
//    [SwaggerSchema(ReadOnly = true)]
//    public int TokensCompletion { get; set; }

//    /// <summary>
//    ///     Tokens used by prompt on AI engine
//    /// </summary>    
//    [AllowUpdate(false)]
//    [SwaggerSchema(ReadOnly = true)]
//    public int TokensPrompt { get; set; }
//}

///// <summary>
/////     AI call analysis variable that AI engine outputs
///// </summary>
//public class AiCallAnalysisVariableOutput
//{
//    /// <summary>
//    ///     There cannot be two variable names with the same name
//    /// </summary>
//    [UbluxValidationNotRequired]
//    public required string Name { get; set; }

//    /// <summary>
//    ///     Type of variable. There are some that are complex that are predefined such as Sentiment that contains positive, neutral and negative values.
//    /// </summary>
//    [UbluxValidationNotRequired]
//    public AiVariableType AiVariableType { get; set; }

//    /// <summary>
//    ///     Value of variable
//    /// </summary>
//    public string? Value { get; set; }
//}
