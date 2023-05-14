#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Trunk used to receive phone calls
/// </summary>
public partial class TrunkTermination : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Example: VP.Twilio
    ///     The id of the provider and NOT the id of the trunk. For example
    /// </summary>
    [References(typeof(VoipProvider))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string IdVoipProvider { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     This is the id that the provider has and not ublux. Example: TKaf8091afbf6f8d9299a021b87c5e6f61
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string ProviderId { get; set; } = string.Empty;

    /// <summary>
    ///     Url where to send calls
    /// </summary>
    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [UbluxValidationStringRange(500)]
    public required string TerminationUri { get; set; } = string.Empty;

    /// <summary>
    ///     Username that provider requires in order to authenticate. Optional because provider may validate us via ip address
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? Username { get; set; }

    /// <summary>
    ///     Password that provider requires in order to authenticate
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? Password { get; set; }

    /// <summary>
    ///     This contains countries that should call. but in case of an emergency this trunk will be used.
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [BsonRepresentation(BsonType.String)]
    public required List<CountryIsoCode> CountryIsoCodesThatCanCall { get; set; } = new();

    /// <summary>
    ///     Friendly name
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    ///// <summary>
    /////     Is trunk encrypted?
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool IsSecure { get; set; }

    /// <summary>
    ///     Company of this provider for example Twilio
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required VoipCompany VoipCompany { get; set; }

    #endregion

    #region Helper methods

    /// <summary>
    ///     Can call country
    /// </summary>
    public static bool CanCallCountry(IList<CountryIsoCode> countryIsoCodes, CountryIsoCode country)
    {
        if (countryIsoCodes == null)
            return false;

        if (countryIsoCodes.Count < 1)
            return false;

        if (countryIsoCodes.Any(x => x == CountryIsoCode.All))
            return true;

        return countryIsoCodes.Contains(country);
    }

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

#endif