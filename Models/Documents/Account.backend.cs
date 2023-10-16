#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux Account
/// </summary>
public partial class Account
{
    #region References

    /// <summary>
    ///     Trunks that will be used for outgoing calls ordered by priority. Points to collection Group_TrunkTerminations
    ///     Reference to another entity on database. 
    ///     Example: GP-CANALPARK-PRODUCTION-1
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(TrunkTerminationGroup))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string IdGTrunkTerminationGroup { get; set; } = string.Empty;

    #endregion

    ///// <summary>
    /////     Continental assists has 2 providers on their phones.
    /////     Thanks to this Variable we may ignore an account so that we do not override properties from Netelip for example.
    /////
    /////     For example value {3,4} will reserve accounts 3 and 4 for personal use of Continental assist
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[IgnoreDataMember]
    //public List<int> ReserveAccountsOnPhone { get; set; } = new();

    /// <summary>
    ///     Was this account sold by CanalPark, Victor, Daniel?
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public UbluxPartner UbluxPartner { get; set; }

    /// <summary>
    ///     Id of account where phones that are TBD connect.
    /// </summary>
    public static readonly BuiltId IdTbdCase27 = Account.BuildId("27");

    /// <summary>
    ///     Get default country. Its the first country that it can call locally that is not none or all
    /// </summary>
    public CountryIsoCode? GetDefaultCountry()
    {
        foreach (var item in this.CountriesThatCanCallLocally
                .Where(item => item != CountryIsoCode.None && item != CountryIsoCode.All))
            return item;

        return null;
    }
}

#endif


