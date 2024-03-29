﻿namespace Ublux.Communications.Models.Documents;

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
    public required EventTriggerType EventTriggerType { get; set; }

    /// <summary>
    ///     Friendly name of webhook
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; }

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
    public List<string> Headers { get; set; } = [];

    /// <summary>
    ///     Description of webhook
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(0, 4000)]
    public string? Description { get; set; }

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

        // enable searching fast by URL
        yield return new MongoDbIndex(collection, nameof(Url))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by event trigger
        yield return new MongoDbIndex(collection, nameof(EventTriggerType))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}
