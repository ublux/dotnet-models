namespace Ublux.Communications.Models.Documents;

/// <summary>
///     SMS message
/// </summary>
public partial class SMS : UbluxDocument_ReferenceAccount_ReferenceTags
{

    #region Properties

    #region References

    /// <summary>
    ///     VOIP number that sent/received SMS message
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(VoipNumber))]
    [UbluxValidationRequired]
    public required string IdVoipNumber { get; set; } = string.Empty;

    /// <summary>
    ///     Contact
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Contact))]
    public string? IdContact { get; set; }

    /// <summary>
    ///     If its an outgoing message the user that sent the message. If its an incoming sms then this will be null
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(User))]
    public string? IdUser {  get; set; }

    #endregion

    /// <summary>
    ///     Composed of the IdVoipNumber + (last 8 digits of phone number ContactNumber). Example VNP.12345678-98765432
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public string ConversationId
    {
        get
        {
            if (IsIncoming)
            {
                return $"{IdVoipNumber}-{VoipNumber.GetLast8DigitsOfPhoneNumber(From)}";
            }

            return $"{IdVoipNumber}-{VoipNumber.GetLast8DigitsOfPhoneNumber(To)}";
        }
        set
        {
            // ignore read only
        }
    }


    /// <summary>
    ///     True if SMS was received false otherwise
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public bool IsIncoming { get; set; }

    /// <summary>
    ///     SMS message
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(4000)]
    public required string Body { get; set; } = string.Empty;

    //    // [AllowUpdate(false)]
    //public int? ZipCode { get; set; }

    /// <summary>
    ///     If a SMS body is to large, it will be sent in multiple chunks/segments
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required int NumSegments { get; set; }

    ///// <summary>
    /////     Status of SMS
    ///// </summary>
    //[AllowUpdate(false)] 
    //[SwaggerSchema(ReadOnly = true)] 
    //public string? Status { get; set; }

    //    // [AllowUpdate(false)]
    //public decimal? Price { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaUrl { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaSid { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaName { get; set; }

    //    // [AllowUpdate(false)]
    //public int MediaType { get; set; }

    /// <summary>
    ///     Number that sent SMS
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(1, 20)]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     Only used on mongo in oder to search fast on queries by index
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string FromReversed
    {
        get
        {
            return From.ReverseString();
        }
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Number to whom SMS was sent to 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(1, 20)]
    public required string To { get; set; } = string.Empty;

    /// <summary>
    ///     Only used on mongo in oder to search fast on queries by index
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string ToReversed
    {
        get
        {
            return To.ReverseString();
        }
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        #region From/To reversed

        // Search by from and id of account
        yield return new MongoDbIndex(collection, nameof(FromReversed)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        // Search by to and id of account
        yield return new MongoDbIndex(collection, nameof(ToReversed)).Add(nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(-1, nameof(DateCreated));

        #endregion

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }

    #endregion
}
