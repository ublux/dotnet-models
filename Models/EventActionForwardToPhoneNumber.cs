namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to a cell phone or land line because call was not answered
/// </summary>
public class EventActionForwardToPhoneNumber : EventAction
{
    /// <inheritdoc/>
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override EventActionType EventActionType
    {
        get => EventActionType.ForwardToPhoneNumber;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }

    /// <summary>
    ///     Phone number where to forward the call
    /// </summary>
    [IsUbluxRequired]
    public required string PhoneNumber { get; set; }
}
