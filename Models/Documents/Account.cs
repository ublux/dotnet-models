namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux Account
/// </summary>
public partial class Account : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Example, US-1, MX-1
    ///     Must have at least one
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(CloudServicePbx))]
    [UbluxValidationIsRequired]
    public required List<string> IdsCloudServicePbxs { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Address
    /// </summary>    
    [AllowUpdate(true)]
    public MailingAddress? MailingAddress { get; set; }

    /// <summary>
    ///     Account secrets
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationIsRequired]
    public required AccountSecrets AccountSecrets { get; set; } = AccountSecrets.GenerateRandom();

    #endregion

    /// <summary>
    ///     Name of company
    /// </summary>    
    [AllowUpdate(true)]
    [UbluxValidationIsRequired]
    public required string CompanyName { get; set; } = string.Empty;

    /// <summary>
    ///     If client has granted access to support to make changes to account. 
    ///     This can only be changed by an ownder of the account.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public bool HasGrantedSupportAccess { get; set; }

    /// <summary>
    ///     Countries on this list will not be marked as international calls
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [BsonRepresentation(BsonType.String)]
    public List<CountryIsoCode> CountriesThatCanCallLocally { get; set; } = new();

    /// <summary>
    ///     If CountriesThatCanCallLocally does not contain country then ublux will attempt to find country on this list.
    /// </summary>
    [AllowUpdate(true)]
    // [SwaggerSchema(ReadOnly = true)]
    [BsonRepresentation(BsonType.String)]
    // [IsUbluxRequired]
    public List<CountryIsoCode> CountriesThatCanCallInternationally { get; set; } = new();

    /// <summary>
    ///     Sector
    /// </summary>
    [AllowUpdate(true)]
    [BsonRepresentation(BsonType.String)]
    public Industry Industry { get; set; }

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

        // Enable seraching by date created only with accounts.
        // db.getCollection("AgreementsToTermsAndConditions").createIndex({ 'dateCreated' : 1 })
        yield return new MongoDbIndex(collection, nameof(DateCreated));
    }

    #endregion

    #region Helper methods

    /// <summary>
    ///     The default country is code is the first country that can be called locally
    /// </summary>
    /// <returns></returns>
    public CountryIsoCode GetDefaultCountryIsoCode()
    {
        return CountriesThatCanCallLocally.FirstOrDefault();
    }

    /// <summary>
    ///     Returns true if call is international
    /// </summary>
    public bool IsCallMadeToThisCountryInternational(CountryIsoCode country)
    {
        if (CountriesThatCanCallLocally == null || CountriesThatCanCallLocally.Count < 1)
            return true;

        // This is strange? How come calling to all countries is marked as local calls?
        if (CountriesThatCanCallLocally.Any(x => x == CountryIsoCode.All))
            return false;

        return !CountriesThatCanCallInternationally.Contains(country);
    }

    /// <summary>
    ///     Can this account call this country?
    /// </summary>
    public bool CanCallCountry(CountryIsoCode country)
    {
        foreach (var item in CountriesThatCanCallLocally)
            if (item == country || item == CountryIsoCode.All)
                return true;

        foreach (var item in CountriesThatCanCallInternationally)
            if (item == country || item == CountryIsoCode.All)
                return true;

        return false;
    }

    #endregion

}
