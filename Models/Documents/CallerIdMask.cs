namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class CallerIdMask : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    /// <summary>
    ///     The phone that will be used as caller id
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string PhoneNumber { get; set; } = string.Empty;

    /// <summary>
    ///     Name of this caller id mask
    /// </summary>
    [AllowUpdate(true)]    
    [UbluxValidationIsRequired]
    public required string FriendlyName { get; set; } = string.Empty;

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

        // enable searching fast by phone number
        yield return new MongoDbIndex(collection, nameof(this.PhoneNumber))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}