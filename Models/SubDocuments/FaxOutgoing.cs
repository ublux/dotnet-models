using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     Outgoing fax
/// </summary>
public partial class FaxOutgoing : UbluxSubDocument
{
    /// <summary>
    ///     Number of pages that Pdf contains
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required int NumberOfPages { get; set; }

    /// <summary>
    ///     Status of fax sent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string FaxStatus { get; set; }

    /// <summary>
    ///     Fax number to where fax was sent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string To { get; set; }

    /// <summary>
    ///     Description of error
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     Path where Pdf exists on disk
    /// </summary>
    private string? pdfFilePath;

    /// <summary>
    ///     Setter
    /// </summary>
    public string? GetPdfFilePath() => pdfFilePath;
    /// <summary>
    ///     Getter
    /// </summary>
    public void SetPdfFilePath(string? pdfFilePath) => this.pdfFilePath = pdfFilePath;

    /// <summary>
    ///     Pdf to be sent as a fax
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required StoredFile Pdf { get; set; }

    /// <summary>
    ///     Number of pages that where actually sent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int NumberOfPagesSent { get; set; }

    /// <summary>
    ///     Is pdf in portrait or landscape mode?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public bool? IsPortrait { get; set; }

    /// <summary>
    ///     File name of attachment
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string Name { get; set; }

    /// <summary>
    ///     Used in case the line is busy to retry again
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public int NumberOfAttempts { get; set; }
}
