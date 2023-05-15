#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Store when user agreed to UBLUX terms and conditions for legal reasons.
/// </summary>
public partial class AgreementToTermsAndConditions : UbluxDocument
{
    #region Properties

    #region Subdocuments

    /// <summary>
    ///     Current session when user agreed to terms and conditions. This session should contain id of user that agreed
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required UbluxSession UbluxSession { get; set; }

    #endregion

    /// <summary>
    ///     Ip address of client that agreed to terms and conditions
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(50)]
    public required string Ip { get; set; } = string.Empty;

    /// <summary>
    ///     Headers of client
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string HttpRequestHeaders { get; set; } = string.Empty;

    /// <summary>
    ///     Section to terms and conditions that user agreed to
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required TermsAndConditionsCategory TermsAndConditionsCategory { get; set; }

    ///// <summary>
    /////     Description of this agreement
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public string? Description { get; set; }

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

        // db.getCollection("AgreementsToTermsAndConditions").createIndex({ 'ip' : 1 })
        yield return new MongoDbIndex(collection, nameof(Ip));
        // db.getCollection("AgreementsToTermsAndConditions").createIndex({ 'ubluxSession.idUser' : 1 })
        yield return new MongoDbIndex(collection, nameof(UbluxSession), nameof(UbluxSession.IdUser));
        // db.getCollection("AgreementsToTermsAndConditions").createIndex({ 'ubluxSession.idAccount' : 1 })
        yield return new MongoDbIndex(collection, nameof(UbluxSession), nameof(UbluxSession.IdAccount));
    }

    #endregion
}

#endif