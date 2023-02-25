namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to another extension because call was not answered
/// </summary>
public class EventActionForwardToExtension : EventAction
{
    /// <inheritdoc/>
    [IsUbluxRequired]
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
    [IsUbluxRequired]
    public required string IdExtension { get; set; }
}
