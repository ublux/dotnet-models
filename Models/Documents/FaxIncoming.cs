namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming fax
/// </summary>
public partial class FaxIncoming : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Received fax from this VOIP number. This could also be named the 'To' property.
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(VoipNumberFax))]
    [IsRequired]
    public string IdVoipNumberFax { get; set; } = String.Empty;

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
    [IsRequired]
    public string FaxStatus { get; set; } = String.Empty;

    /// <summary>
    ///     Fax number of sender
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string From { get; set; } = String.Empty;

    /// <summary>
    ///     Fax number that received the fax
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string To { get; set; } = String.Empty;

    /// <summary>
    ///     Description of error if there is one
    /// </summary>
    [AllowUpdate(false)]
    public string? ErrorMessage { get; set; }

    #endregion
}
