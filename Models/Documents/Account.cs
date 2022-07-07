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
    [References(typeof(CloudServicePbx))]
    [IsRequired]
    public required List<string> IdsCloudServicePbxs { get; set; }

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
    [IsRequired]
    public required AccountSecrets AccountSecrets { get; set; } 

    /// <summary>
    ///     Customizable settings
    /// </summary>    
    [AllowUpdate(true)]
    [IsRequired]
    public required AccountSettings AccountSettings { get; set; } 

    #endregion

    /// <summary>
    ///     Name of company
    /// </summary>    
    [AllowUpdate(true)]
    [IsRequired]
    public required string CompanyName { get; set; }

    /// <summary>
    ///     If client has granted access to support to make changes to account
    /// </summary>
    [AllowUpdate(false)]
    public bool HasGrantedSupportAccess { get; set; }

    /// <summary>
    ///     Countries on this list will not be marked as international calls
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [BsonRepresentation(BsonType.String)]
    public List<CountryIsoCode> CountriesThatCanCallLocally { get; set; } = new();

    /// <summary>
    ///     If CountriesThatCanCallLocally does not contain country then ublux will attempt to find country on this list.
    /// </summary>
    [AllowUpdate(false)]
    [BsonRepresentation(BsonType.String)]
    public List<CountryIsoCode> CountriesThatCanCallInternationally { get; set; } = new();

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

