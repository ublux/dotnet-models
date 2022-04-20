namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     Outgoing fax
/// </summary>
public class FaxOutgoing : UbluxSubDocument
{
    ///// <inheritdoc />
    //public override string SubDocumentPrefix() => "SubFO";

    ///// <inheritdoc />
    //public override void SetId() => _id = $"{UCore.InstanceId}:{SubDocumentPrefix()}:{DateTime.UtcNow.ToUnixEpoch()}:{Interlocked.Increment(ref DomainGlobals.IdGenerationCounter)}";

    /// <summary>
    ///     This is a subdocument. Id of parent
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(FaxOutgoingGroup))]
    [IsRequired]
    public string IdFaxOutgoingGroup { get; set; } = string.Empty;

    ///// <summary>
    /////     Id of fax
    ///// </summary>
    //[AllowUpdate(false)]
    //[IgnoreDataMember]
    //[IsRequired]
    //public string ClientFaxId { get; set; } = string.Empty;

    /// <summary>
    ///     Number of pages that Pdf contains
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public int NumberOfPages { get; set; }

    /// <summary>
    ///     Status of fax sent
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string FaxStatus { get; set; } = string.Empty;

    /// <summary>
    ///     Fax number to where fax was sent
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string To { get; set; } = string.Empty;

    /// <summary>
    ///     Description of error
    /// </summary>
    [AllowUpdate(false)]
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     Email attachment that was converted to fax
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public EmailAttachment EmailAttachment { get; set; } = new EmailAttachment();

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
    [IsRequired]
    public StoredFile Pdf { get; set; } = new();

    /// <summary>
    ///     Number of pages that where actually sent
    /// </summary>
    [AllowUpdate(false)]
    public int NumberOfPagesSent { get; set; }

    /// <summary>
    ///     Is pdf in portrait or landscape mode?
    /// </summary>
    [AllowUpdate(false)]
    public bool? IsPortrait { get; set; }

    /// <summary>
    ///     File name of attachment
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     True when done sending fax
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public bool IsComplete { get; set; }

    /// <summary>
    ///     Used in case the line is busy to retry again
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public int NumberOfAttempts { get; set; }

    /// <summary>
    ///     Determine if fax contains an error
    /// </summary>
    public bool ContainsError()
    {
        return !string.IsNullOrEmpty(ErrorMessage);
    }



  
}
