namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to another extension because call was not answered
/// </summary>
public class EventActionForwardToExtension : EventAction
{
    /// <inheritdoc/>
    [UbluxValidationIsRequired]
    public override EventActionType EventActionType
    {
        get => EventActionType.ForwardToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Extension where to forward call
    /// </summary>
    [References(typeof(Extension))]
    [UbluxValidationIsRequired]
    public required string IdExtension { get; set; }
}
