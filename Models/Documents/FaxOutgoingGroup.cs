namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of faxes sent as a group via email
/// </summary>
public partial class FaxOutgoingGroup : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of Fax VoipNumber (virtual number) that sent the fax
    /// </summary>    
    [References(typeof(VoipNumberFax))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required string IdVoipNumberFax { get; set; } = string.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     There must be at least one fax attachment
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public List<FaxOutgoing> FaxesOutgoing { get; set; } = new();

    ///// <summary>
    /////     Email that was sent to fax@ublux.com
    ///// </summary>
    //[AllowUpdate(false)] 
    //[SwaggerSchema(ReadOnly = true)] 
    //[IsUbluxRequired]
    //public required FaxEmail FaxEmail { get; set; }

    #endregion

    /// <summary>
    ///     Phone number where fax is sent
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required string From { get; set; } = string.Empty;    

    /// <summary>
    ///     To phone number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string To { get; set; }

    /// <summary>
    ///     To country
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required CountryIsoCode ToCountry { get; set; }

    /// <summary>
    ///     If fax is sent successfully then send confirmation to this emails
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Email))]
    public List<string> IdsEmailsSendConfirmation { get; set; } = new();

    /// <summary>
    ///     Error message
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> Errors { get; set; } = new();

    /// <summary>
    ///     The status. Is it pending, processing or complete?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public ProcessStatus Status { get; set; }

    #endregion


    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // We use this query to see if an email can be deleted
        // Search fast by IdsEmailsSendConfirmation and status 
        yield return new MongoDbIndex(collection, nameof(IdsEmailsSendConfirmation)).Add(nameof(Status))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));
    }

    #endregion
}
