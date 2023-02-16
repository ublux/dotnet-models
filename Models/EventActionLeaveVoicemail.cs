namespace Ublux.Communications.Models;

/// <summary>
///     Leave voicemail because call was not answered
/// </summary>
public class EventActionLeaveVoicemail : EventAction
{
    /// <inheritdoc/>
    [IsUbluxRequired]
    public override EventActionType EventActionType
    {
        get => EventActionType.LeaveVoicemail;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <summary>
    ///     Emails where to send voicemails
    /// </summary>
    [IsUbluxRequired]
    [References(typeof(Email))]
    [AllowUpdate(true)]
    public required string IdEmail { get; set; } = "";

    /// <summary>
    ///     Optional audio to play to instruct caller how to leave a voicemail. 
    ///     If not specified then a default audio will be played. 
    ///     The audio will say "Hello! You have reached the voicemail of ${NameOfExtension}. Please leave a detailed message after the beep. Thank you."
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    public string? IdAudio { get; set; }
}