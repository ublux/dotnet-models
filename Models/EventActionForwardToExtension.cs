namespace Ublux.Communications.Models;

/// <summary>
///     Forward call to another extension because call was not answered
/// </summary>
public class EventActionForwardToExtension : EventAction
{
    /// <inheritdoc/>
    [IsRequired]
    public override EventActionType EventActionType { get; } = EventActionType.ForwardToExtension;

    /// <summary>
    ///     Extension where to forward call
    /// </summary>
    [References(typeof(Extension))]
    [IsRequired]
    public string IdExtension { get; set; } = String.Empty;
}
