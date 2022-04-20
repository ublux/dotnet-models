namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Email attachment
/// </summary>
public class EmailAttachment
{
    /// <summary>
    ///     Id of attachment
    /// </summary>
    [Required]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     To what email it points to
    /// </summary>
    [Required]
    public string IdFaxEmailInfo { get; set; } = String.Empty;

    /// <summary>
    ///     Attachment name
    /// </summary>
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     Location in disk where attachment was downloaded
    /// </summary>
    public string? FilePath { get; set; }

    /// <summary>
    ///     Mime type
    /// </summary>
    public string? MimeType { get; set; }
}
