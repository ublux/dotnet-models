namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to another extension because call was not answered
/// </summary>
public class EventActionForwardToExtension : EventAction
{
    /// <inheritdoc/>
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override EventActionType EventActionType
    {
        get => EventActionType.ForwardToExtension;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }

    /// <summary>
    ///     Extension where to forward call
    /// </summary>
    [References(typeof(Extension))]
    [IsUbluxRequired]
    public required string IdExtension { get; set; }
}
