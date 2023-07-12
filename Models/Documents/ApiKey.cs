namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Only users can have api keys. Everyone else should have a JWT
/// </summary>
[BsonIgnoreExtraElements]
public partial class ApiKey : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References    

    /// <summary>
    ///     User that created this key. 
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(User))]
    public required string IdUser { get; set; } = string.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    ///     Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify. 
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    [BsonRepresentation(BsonType.String)]
    public required List<UbluxRole> UbluxRoles { get; set; } = new();

    #endregion    

    /// <summary>
    ///     Api key. Contains DB index.
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationStringRange(300)]
    public required string Key { get; set; } = string.Empty;

    /// <summary>
    ///     If null it will never expire. Else it will have an expiration
    /// </summary>
    [AllowUpdate(true)]
    public DateTime? DateExpire { get; set; }

    /// <summary>
    ///     Is expired?
    /// </summary>
    public bool IsExpired() => DateTime.UtcNow > DateExpire;

    /// <summary>
    ///     Date last authenticated
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateLastUsed { get; set; }

    /// <summary>
    ///     Description or notes of API key
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(2000)]
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

        // Enable searching fast by key
        yield return new MongoDbIndex(collection, nameof(Key));
    }

    #endregion
}
