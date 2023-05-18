namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of trunk terminations ordered by priority
/// </summary>
public partial class TrunkTerminationGroup : UbluxDocument
{
    /// <summary>
    ///     Note: points to a shared_trunktermination and not a trunk termination
    ///     Example. ID of a twilio trunk to call US, then a trunk from victor to call Spain, then trunk
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    // [References(typeof(TrunkTerminationRule))]
    [UbluxValidationRequired]
    public required List<TrunkTerminationRule> TrunkTerminationRulesOrderedByPriority { get; set; } = new();

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

/// <summary>
///     Trunk termination allowed to call
/// </summary>
public class TrunkTerminationRule
{
    /// <summary>
    ///     Trunk termination to use
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(TrunkTermination))]
    [UbluxValidationRequired]
    public required string IdTrunkTermination { get; set; } = "";

    /// <summary>
    ///     Countries that can be called
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [BsonRepresentation(BsonType.String)]
    public required List<CountryIsoCode> CountriesThatCanCall { get; set; } = new ();
}
