namespace Ublux.Communications.Models;

/// <summary>
///     Leave voicemail because call was not answered
/// </summary>
public class EventActionLeaveVoicemail : EventAction
{
    /// <inheritdoc/>
    [IsRequired]
    public override EventActionType EventActionType { get; } = EventActionType.LeaveVoicemail;

    /// <summary>
    ///     Email where to send voicemail
    /// </summary>
    [IsRequired]
    public required string Email { get; set; }

    /// <summary>
    ///     Optional audio to play to instruct caller how to leave a voicemail. 
    ///     If not specified then a default audio will be played. 
    ///     The audio will say "Hello! You have reached the voicemail of ${NameOfExtension}. Please leave a detailed message after the beep. Thank you."
    /// </summary>
    [References(typeof(Audio))]
    public string? IdAudio { get; set; }
}