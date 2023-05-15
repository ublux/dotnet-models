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
    [UbluxValidationRequired]
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
    [UbluxValidationRequired]
    public required string FaxStatus { get; set; } = string.Empty;

    /// <summary>
    ///     Fax number of sender
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     Fax number that received the fax
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required string To { get; set; } = string.Empty;

    /// <summary>
    ///     Description of error if there is one
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(2000)]
    public string? ErrorMessage { get; set; }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }

    #endregion
}
