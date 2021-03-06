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
    ///     Example: AC82d45e10fd7a7681d95a49dcff596e93
    ///     The id of the provider and NOT the id of the trunk. For example
    /// </summary>
    [References(typeof(VoipProvider))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdVoipProvider { get; set; }

    ///// <summary>
    /////     Needed so that we do not create two trunk terminations that are actually the same on sip.conf. One will be able to call China and the other not but they are the same
    ///// </summary>
    //[References(typeof(TrunkTermination))]
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public string? IdTrunkTerminationExisting { get; set; }

    #endregion

    /// <summary>
    ///     This is the id that the provider has and not ublux. Example: TKaf8091afbf6f8d9299a021b87c5e6f61
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required string ProviderId { get; set; }

    /// <summary>
    ///     Url where to send calls
    /// </summary>
    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required string TerminationUri { get; set; }

    /// <summary>
    ///     Username that provider requires in order to authenticate. Optional because provider may validate us via ip address
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? Username { get; set; }

    /// <summary>
    ///     Password that provider requires in order to authenticate
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? Password { get; set; }

    /// <summary>
    ///     This contains countries that should call. but in case of an emergency this trunk will be used.
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    [BsonRepresentation(BsonType.String)]
    public required List<CountryIsoCode> CountryIsoCodesThatCanCall { get; set; }

    /// <summary>
    ///     Friendly name
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required string FriendlyName { get; set; }

    ///// <summary>
    /////     Is trunk encrypted?
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool IsSecure { get; set; }

    #endregion

    #region Helper methods

    /// <summary>
    ///     Can call country
    /// </summary>
    public bool CanCallCountry(CountryIsoCode country)
    {
        if (CountryIsoCodesThatCanCall == null)
            return false;

        if (CountryIsoCodesThatCanCall.Count < 1)
            return false;

        if (CountryIsoCodesThatCanCall[0] == CountryIsoCode.All)
            return true;

        return CountryIsoCodesThatCanCall.Contains(country);
    }

    #endregion
}

#endif