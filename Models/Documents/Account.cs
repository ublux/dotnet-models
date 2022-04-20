namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Ublux Account
/// </summary>
public partial class Account : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Failover pbx that will be used for account
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(CloudServicePbx))]
    [Required]
    public string IdCloudServicePbxFailover { get; set; } = String.Empty;

    /// <summary>
    ///     Reference to webAppCloudService. Thanks to this we know where to send events. For example on pbx when we receive a new phone call we send that event to CloudServicePbx
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(CloudServiceWebApp))]
    [Required]
    public string IdCloudServiceWebApp { get; set; } = String.Empty;

    /// <summary>
    ///     Trunks that will be used for outgoing calls ordered by priority. Points to collection Group_TrunkTerminations
    ///     Reference to another entity on database. 
    ///     Example: GP-CANALPARK-PRODUCTION-1
    ///     
    ///     ON PBX THIS CONTAINS THE IDS SEPARATED BY COMMA. When pbx requests for Accounts WS will modify this property and perform the join
    ///     Example: Production-CanalPark-Twilio-US-1,Production-CanalPark-Netbox-MX-1,Production-CanalPark-Netbox-All-1
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(TrunkTerminationGroup))]
    [AllowUpdate(false)]
    [Required]
    public string IdGTrunkTerminationGroup_Or_ValuesSeparatedByCommaIfOnPbx { get; set; } = String.Empty;

    /// <summary>
    ///     Example, US-1, MX-1
    ///     Must have at least one
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(CloudServicePbx))]
    [Required]
    public List<string> IdsCloudServicePbxs { get => _IdsCloudServicePbxs; set { if (value is null) _IdsCloudServicePbxs.Clear(); else _IdsCloudServicePbxs = value; } }
    List<string> _IdsCloudServicePbxs = new();

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
    [Required]
    public AccountSecrets AccountSecrets { get; set; } = new AccountSecrets();

    /// <summary>
    ///     Customizable settings
    /// </summary>    
    [AllowUpdate(true)]
    [Required]
    public AccountSettings AccountSettings { get; set; } = new();

    #endregion

    /// <summary>
    ///     Name of company
    /// </summary>    
    [AllowUpdate(true)]
    [Required]
    public string CompanyName { get; set; } = String.Empty;

    /// <summary>
    ///     Continental assists has 2 providers on their phones.
    ///     Thanks to this Variable we may ignore an account so that we do not override properties from Netelip for example.
    ///
    ///     For example value {3,4} will reserver accounts 3 and 4 for personal use of Continental assist
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public List<int> ReserveAccountsOnPhone
    {
        get => _ReserveAccountsOnPhone;
        set { if (value is null) _ReserveAccountsOnPhone.Clear(); else _ReserveAccountsOnPhone = value; }
    }
    List<int> _ReserveAccountsOnPhone = new();

    /// <summary>
    ///     If client has granted access to support to make changes to account
    /// </summary>
    [AllowUpdate(false)]
    public bool HasGrantedSupportAccess { get; set; }

    /// <summary>
    ///     Was this account sold by CanalPark, Victor, Daniel?
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public UbluxPartner UbluxPartner { get; set; }

    /// <summary>
    ///     Countries on this list will not be marked as international calls
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [BsonRepresentation(BsonType.String)]
    public List<CountryIsoCode> CountriesThatCanCallLocally
    {
        get => _CountriesThatCanCallLocally;
        set { if (value is null) _CountriesThatCanCallLocally.Clear(); else _CountriesThatCanCallLocally = value; }
    }
    List<CountryIsoCode> _CountriesThatCanCallLocally = new();

    /// <summary>
    ///     If CountriesThatCanCallLocally does not contain country then ublux will attempt to find country on this list.
    /// </summary>
    [AllowUpdate(false)]
    [BsonRepresentation(BsonType.String)]
    public List<CountryIsoCode> CountriesThatCanCallInternationally
    {
        get => _CountriesThatCanCallInternationally;
        set { if (value is null) _CountriesThatCanCallInternationally.Clear(); else _CountriesThatCanCallInternationally = value; }
    }
    List<CountryIsoCode> _CountriesThatCanCallInternationally = new();

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

