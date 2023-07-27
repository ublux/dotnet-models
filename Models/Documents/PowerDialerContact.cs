namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Peer to call on power dialer group
/// </summary>
//[JsonConverter(typeof(JsonSubtypes), nameof(PowerDialerType))]
//[JsonSubtypes.KnownSubType(typeof(PowerDialerSimple), nameof(PowerDialerType.Simple))]
//[JsonSubtypes.KnownSubType(typeof(PowerDialerAdvance), nameof(PowerDialerType.Advanced))]
//[BsonKnownTypes(
//    typeof(PowerDialerAdvance),
//    typeof(PowerDialerSimple)
//)]
public partial class PowerDialerContact : UbluxDocument_ReferenceAccount_ReferenceTags
{
    /// <summary>
    ///     To what power dialer group
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(PowerDialerGroup))]
    public required string IdPowerDialerGroup { get; set; }

    /// <summary>
    ///     Phone number to call
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string PhoneNumber { get; set; }

    ///// <summary>
    /////     If a call flow logic needs to be executed before calling contact.
    ///// </summary>
    //[References(typeof(CallFlowLogic))]
    //public string? IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Country ISO code of phone number to call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     Id of contact
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Contact))]
    public string? IdContact { get; set; }

    /// <summary>
    ///     Date when powerdialer group started
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateStarted { get; set; }

    /// <summary>
    ///     Date when powerdialer group ended
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateEnded { get; set; }

    /// <summary>
    ///     Status of this item
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required PowerDialerStatus PowerDialerStatus { get; set; }

    /// <summary>
    ///     Error message
    /// </summary>
    [UbluxValidationStringRange(1000)]
    [AllowUpdate(true)]
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     If powerdialer fails it attempts to call again. If it reaches 3 attempts and fails it will stop
    /// </summary>
    [AllowUpdate(true)]
    public int NumberOfAttempts { get; set; }

    /// <summary>
    ///     Name of the contact in order to know who are we calling
    /// </summary>
    [AllowUpdate(true)]
    public string? ContactName { get; set; }

    /// <summary>
    ///     Create indexes
    /// </summary>
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by IdPowerDialerGroup
        yield return new MongoDbIndex(collection, nameof(this.IdPowerDialerGroup))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }
}
