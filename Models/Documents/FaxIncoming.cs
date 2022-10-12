namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming fax
/// </summary>
public partial class FaxIncoming : UbluxDocument, IReferencesTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Received fax from this VOIP number. This could also be named the 'To' property.
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(VoipNumberFax))]
    [IsUbluxRequired]
    public required string IdVoipNumberFax { get; set; }

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    /// Received Pdf
    /// </summary>
    [AllowUpdate(false)]
    public StoredFile? Pdf { get; set; }

    #endregion

    /// <summary>
    ///     Number of pages received
    /// </summary>
    [AllowUpdate(false)]
    public int NumPages { get; set; }

    /// <summary>
    ///     Status of fax
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string FaxStatus { get; set; }

    /// <summary>
    ///     Fax number of sender
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string From { get; set; }

    /// <summary>
    ///     Fax number that received the fax
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string To { get; set; }

    /// <summary>
    ///     Description of error if there is one
    /// </summary>
    [AllowUpdate(false)]
    public string? ErrorMessage { get; set; }

    #endregion
}
