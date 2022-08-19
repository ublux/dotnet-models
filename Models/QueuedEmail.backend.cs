#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Every time we send an email we queued on disk so that it is not lost
/// </summary>
public class QueuedEmail
{
    /// <summary>
    /// 
    /// </summary>
    public const string EXTENSION_OK = ".json";
    /// <summary>
    /// 
    /// </summary>
    public const string EXTENSION_ERROR = ".error";

    /// <summary>
    ///     Mark id with error
    /// </summary>
    public void MarkIdWithError()
    {
#pragma warning disable CS0618 // Ok to change if there is an error
        if (this.Id.EndsWith(EXTENSION_ERROR))
            return;
        this.Id += EXTENSION_ERROR;
#pragma warning restore CS0618 
    }

    /// <summary>
    ///     Id of queued email. This will be the file name if stored on a file system
    /// </summary>
    [Obsolete("Leave as default do not modify")]
    public string Id { get; set; } = BuildId();

    /// <summary>
    ///     Get id
    /// </summary>
#pragma warning disable CS0618 // Ok to get it only do not set it
    public string GetId() => this.Id;
#pragma warning restore CS0618 

    /// <summary>
    ///     Id builder
    /// </summary>
    public static string BuildId() => $"{DateTime.UtcNow.Ticks}-{Guid.NewGuid().ToString()[..4]}{EXTENSION_OK}";

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
    ///     Override to string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
#pragma warning disable CS0618 // Ok to use it
        return $"Id={this.Id} From={this.FromName} To={string.Join(',', this.To)}";
#pragma warning restore CS0618 
    }
}

#endif