namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to a cell phone or land line because call was not answered
/// </summary>
public class EventActionForwardToPhoneNumber : EventAction
{
    /// <inheritdoc/>
    [Required]
        public override EventActionType EventActionType { get; } = EventActionType.ForwardToPhoneNumber;

    /// <summary>
    ///     Phone number where to forward the call
    /// </summary>
    [Required]
    public string PhoneNumber { get; set; } = String.Empty;
}
