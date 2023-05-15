namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public partial class WebHook : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    /// <summary>
    ///     Points to enum and not database!
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required EventTrigger EventTrigger { get; set; }

    /// <summary>
    ///     Url where event will be sent
    ///     TODO: place index on this field. Index is needed because when zapier deletes/unsubscribes it passes this url
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(500)]
    public required string Url { get; set; } = string.Empty;

    /// <summary>
    ///     Custom headers to inject on request. Example: x-token:1234,user:user1
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(500)]
    public List<string> Headers { get; set; } = new();

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

        // enable searching fast by URL
        yield return new MongoDbIndex(collection, nameof(this.Url))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by event trigger
        yield return new MongoDbIndex(collection, nameof(this.EventTrigger))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}
