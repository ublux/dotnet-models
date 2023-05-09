namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming fax
/// </summary>
public partial class FaxIncoming : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Received fax from this VOIP number. This could also be named the 'To' property.
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(VoipNumberFax))]
    [IsUbluxRequired]
    public required string IdVoipNumberFax { get; set; } = string.Empty;

    /// <summary>
    ///     Contact
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Contact))]
    public string? IdContact { get; set; }

    #endregion

    #region Subdocuments

    /// <summary>
    /// Received Pdf
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public StoredFile? Pdf { get; set; }

    #endregion

    /// <summary>
    ///     Number of pages received
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public int NumPages { get; set; }

    /// <summary>
    ///     Status of fax
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public required string FaxStatus { get; set; } = string.Empty;

    /// <summary>
    ///     Fax number of sender
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     Fax number that received the fax
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public required string To { get; set; } = string.Empty;

    /// <summary>
    ///     Description of error if there is one
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? ErrorMessage { get; set; }

    #endregion
}
