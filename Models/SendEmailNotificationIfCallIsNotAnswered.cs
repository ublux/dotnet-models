namespace Ublux.Communications.Models;

/// <summary>
///     Send email notification if call is not answered
/// </summary>
public class SendEmailNotificationIfCallIsNotAnswered
{
    /// <summary>
    ///     Email addresses where to send notification in case call is not answered.
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(true)]
    public required List<string> Emails { get; set; }

    /// <summary>
    ///     If a caller calls and hung up right away then maybe we don't want to send a notification.
    /// </summary>    
    [AllowUpdate(true)]
    public int PreventSendingNotificationIfCallLastsLessThanNSeconds { get; set; } = 5;
}
