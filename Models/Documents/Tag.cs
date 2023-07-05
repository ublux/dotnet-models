namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Category
/// </summary>
public partial class Tag : UbluxDocument_ReferenceAccount
{
    /// <summary>
    ///     Name of tag
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Color of tag
    /// </summary>
    [AllowUpdate(true)]
    public TagColor TagColor { get; set; }

    /// <summary>
    ///     Description of tag
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(1000)]
    public string? Description { get; set; }

    /// <summary>
    ///     Used to place an extra layer of filtering.
    /// </summary>
    [AllowUpdate(true)]
    public UserType UserType { get; set; }

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

