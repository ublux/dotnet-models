namespace Ublux.Communications.Models.Documents;

/// <summary>
///     SMS message
/// </summary>
public partial class SMS : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     VOIP number that sent/received SMS message
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(VoipNumber))]
    [UbluxValidationRequired]
    public required string IdVoipNumber { get; set; } = string.Empty;

    /// <summary>
    ///     Contact
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Contact))]
    public string? IdContact { get; set; }

    #endregion

    /// <summary>
    ///     True if SMS was received false otherwise
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public bool IsIncoming { get; set; }

    /// <summary>
    ///     SMS message
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(4000)]
    public required string Body { get; set; } = string.Empty;

    //    // [AllowUpdate(false)]
    //public int? ZipCode { get; set; }

    /// <summary>
    ///     If a SMS body is to large, it will be sent in multiple chunks/segments
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required int NumSegments { get; set; }

    /// <summary>
    ///     Status of SMS
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? Status { get; set; }

    //    // [AllowUpdate(false)]
    //public decimal? Price { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaUrl { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaSid { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaName { get; set; }

    //    // [AllowUpdate(false)]
    //public int MediaType { get; set; }

    /// <summary>
    ///     Number that sent SMS
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     Number to whom SMS was sent to 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string To { get; set; } = string.Empty;

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
