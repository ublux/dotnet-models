namespace Ublux.Communications.Enums;

/// <summary>
///     Reason why an action executes
/// </summary>
public enum EventActionType
{
    /// <summary>
    ///     If extension is not answered and call is thus forwarded to another extension
    /// </summary>
    ForwardToExtension,

    /// <summary>
    ///     If extension is not answered and call is thus forwarded to an external phone number
    /// </summary>
    ForwardToPhoneNumber,

    /// <summary>
    ///     If extension is not answered and call is is forwarded to voicemail
    /// </summary>
    LeaveVoicemail
}
