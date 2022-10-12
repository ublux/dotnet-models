namespace Ublux.Communications.Models;

/// <summary>
///     EventAction to execute if a specific event occurs. 
///     For example if an extension is not answered send an email notification
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(EventActionType))]
[JsonSubtypes.KnownSubType(typeof(EventActionForwardToExtension), nameof(EventActionType.ForwardToExtension))]
[JsonSubtypes.KnownSubType(typeof(EventActionForwardToPhoneNumber), nameof(EventActionType.ForwardToPhoneNumber))]
[JsonSubtypes.KnownSubType(typeof(EventActionLeaveVoicemail), nameof(EventActionType.LeaveVoicemail))]
[BsonKnownTypes(
    typeof(EventActionForwardToExtension),
    typeof(EventActionForwardToPhoneNumber),
    typeof(EventActionLeaveVoicemail)
)]
public abstract partial class EventAction
{
    /// <summary>
    ///     Reason why this action should execute
    /// </summary>
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public abstract EventActionType EventActionType
    {
        get;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set;
    }
}

