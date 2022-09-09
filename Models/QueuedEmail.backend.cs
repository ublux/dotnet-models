#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Every time we send an email we queued on disk so that it is not lost
/// </summary>
public class QueuedEmail : IUbluxDocumentId
{    
    /// <summary>
    ///     Id of queued email. This will be the file name if stored on a file system
    /// </summary>    
    public string Id { get; init; } = BuildId();
   
    /// <summary>
    ///     Id builder
    /// </summary>
    public static string BuildId() => $"{DateTime.UtcNow.Ticks}-{Guid.NewGuid().ToString()[..4]}.bin";

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
}

#endif