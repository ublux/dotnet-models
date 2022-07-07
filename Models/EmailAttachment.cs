namespace Ublux.Communications.Models;

/// <summary>
///     Email attachment
/// </summary>
public class EmailAttachment
{
    /// <summary>
    ///     Id of attachment
    /// </summary>
    [IsRequired]
    public required string Id { get; set; }

    /// <summary>
    ///     To what email it points to
    /// </summary>
    [IsRequired]
    public required string IdFaxEmailInfo { get; set; }

    /// <summary>
    ///     Attachment name
    /// </summary>
    [IsRequired]
    public required string Name { get; set; }

    /// <summary>
    ///     Location in disk where attachment was downloaded
    /// </summary>
    public string? FilePath { get; set; }

    /// <summary>
    ///     Mime type
    /// </summary>
    public string? MimeType { get; set; }
}
