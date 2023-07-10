namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Configuration of a phone
/// </summary>
public partial class PhoneConfiguration : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Phone keys to use
    /// </summary>
    [References(typeof(SpeedDialGroup))]
    [AllowUpdate(true)]
    public string? IdSpeedDialGroup { get; set; }

    #endregion

    /// <summary>
    ///     Phone configuration name
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Phone configuration description
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(1000)]
    public string? Description { get; set; }

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
