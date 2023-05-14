namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to a cell phone or land line because call was not answered
/// </summary>
public class EventActionForwardToPhoneNumber : EventAction
{
    /// <inheritdoc/>
    [UbluxValidationIsRequired]
    public override EventActionType EventActionType
    {
        get => EventActionType.ForwardToPhoneNumber;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Phone number where to forward the call
    /// </summary>
    [UbluxValidationIsRequired]
    public required string PhoneNumber { get; set; }
}
