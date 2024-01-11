namespace Ublux.Communications.Models.Documents;

/// <summary>
///     When a customer purchases a Phone Number from AirNetworks Provider from Spain he needs to feel the province and population info
/// </summary>
public partial class AirNetworksProvince : UbluxDocument
{
    #region Properties

    /// <summary>
    ///     Example: ALAVA
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string Name { get; set; } = string.Empty;

    /// <summary>
    ///     List of "poblaciones". Example: ABENGIBRE, ABUZADERAS, AGRA....
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public List<string> Populations { get; set; } = [];

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

        // Enable searching fast by name
        yield return new MongoDbIndex(collection, nameof(Name));
    }

    #endregion
}
