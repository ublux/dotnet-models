namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Send email notification if call is not answered
/// </summary>
public class SendEmailNotificationIfCallIsNotAnswered
{
    /// <summary>
    ///     Email addresses where to send notification in case call is not answered.
    /// </summary>
    [IsRequired]
    [AllowUpdate(true)]
    public List<string> Email
    {
        get => _Email;
        set { if (value is null) _Email.Clear(); else _Email = value; }
    }
    List<string> _Email = new();

    /// <summary>
    ///     If a caller calls and hung up right away then maybe we don't want to send a notification.
    /// </summary>    
    [AllowUpdate(true)]
    public int PreventSendingNotificationIfCallLastsLessThanNSeconds { get; set; } = 5;
}
