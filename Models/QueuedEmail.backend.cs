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
    public string Id
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    } = BuildId();

    /// <summary>
    ///     Id of account
    /// </summary>
    public required string IdAccount { get; set; }

    /// <summary>
    ///     Id builder
    /// </summary>
    public static string BuildId() => $"{DateTime.UtcNow.Ticks / 10_000}-{Guid.NewGuid().ToString()[..4]}.bin";

    ///// <summary>
    /////     Thanks to this enum we know from what email to send the email
    ///// </summary>
    //public required UbluxEmail UbluxEmail { get; set; }

    /// <summary>
    ///     Example: Ublux Team
    /// </summary>
    public required string FromName { get; set; }

    /// <summary>
    ///     Cannot be an IdEmail because we may be sending an email to verify an email address for example.
    ///     List of emails where to send email
    /// </summary>
    public required List<string> Emails { get; set; } = new();

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
    ///     Date when queued email was created
    /// </summary>
    public DateTime DateCreated
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    } = DateTime.UtcNow;
}

#endif