namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to a cell phone or land line because call was not answered
/// </summary>
public class EventActionForwardToPhoneNumber : EventAction
{
    /// <inheritdoc/>
    [IsRequired]
    public override EventActionType EventActionType { get; } = EventActionType.ForwardToPhoneNumber;

    /// <summary>
    ///     Phone number where to forward the call
    /// </summary>
    [IsRequired]
    public required string PhoneNumber { get; set; }
}
