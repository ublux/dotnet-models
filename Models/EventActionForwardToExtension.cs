namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Forward call to another extension because call was not answered
/// </summary>
public class EventActionForwardToExtension : EventAction
{
    /// <inheritdoc/>
    [Required]
        public override EventActionType EventActionType { get; } = EventActionType.ForwardToExtension;

    /// <summary>
    ///     Extension where to forward call
    /// </summary>
    [References(typeof(Extension))]
    [Required]
    public string IdExtension { get; set; } = String.Empty;
}
