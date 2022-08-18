#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Every time we send an email we queued on disk so that it is not lost
/// </summary>
public class QueuedEmail
{
    /// <summary>
    ///     Thanks to this enum we know from what email to send the email
    /// </summary>
    public required UbluxEmail UbluxEmail { get; set; }

    /// <summary>
    ///     Example: Ublux Team
    /// </summary>
    public required string FromName { get; set; }

    /// <summary>
    ///     To whom to send the email. It can be multiple recepients
    /// </summary>
    public required List<string> To { get; set; }

    /// <summary>
    ///     Subject of email
    /// </summary>
    public required string Subject { get; set; }

    /// <summary>
    ///     Body of email
    /// </summary>
    public required string Body { get; set; }

    /// <summary>
    ///     Is body of email an attachment?
    /// </summary>
    public required bool IsBodyHtml { get; set; }

    /// <summary>
    ///     Location where attachment is located
    /// </summary>
    public string? PathAttachment { get; set; }   
    
    /// <summary>
    ///     Number of times email has been attempted to be sent
    /// </summary>
    public int NumberOfAttemptsSending { get; set; }
}

#endif