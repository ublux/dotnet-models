namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class BlackListPhoneNumber : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Optional audio to play if call is blocked
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    public string? IdAudioToPlayIfCallIsBlocked { get; set; }   

    #endregion    

    /// <summary>
    ///     The phone number that will be blocked
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationIsRequired]
    public required string Number { get; set; } = string.Empty;

    /// <summary>
    ///     Friendly name of this rule
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

        // enable searching fast by searchIndex fast
        yield return new MongoDbIndex(collection, nameof(this.searchIndex))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}
