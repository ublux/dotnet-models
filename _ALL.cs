namespace Ublux.Communications.Models;

/// <summary>
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database. 
///     Business Logic Models that we work with inherit from this. 
///     We need to work with what is stored on our application. 
///     DTO objects is what we present to clients
/// </summary>
public partial interface IUbluxDocument : IUbluxDocumentId
{
    /// <summary>
    ///     Creation date
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [JsonProperty(Order = 1000)]
    [UbluxValidationRequired]
    DateTime DateCreated { get; set; }

    /// <summary>
    ///     If collection is immutable this is not needed but we have it regardless
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [JsonProperty(Order = 1002)]
    DateTime DateUpdated
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#endif
    }

    /// <summary>
    ///     Get MongoDB indexes
    /// </summary>
    IEnumerable<MongoDbIndex> GetMongoDbIndexes();
}

/// <summary>
///     * This are business logic objects *
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database
/// </summary>
public abstract partial class UbluxDocument : IUbluxDocument, IUbluxDocumentId
{
    /// <summary>
    ///     Id of document
    /// </summary>
    [BsonId]
    //[BsonRepresentation(BsonType.ObjectId)]
    [BsonRepresentation(BsonType.String)] // store id as string
    [BsonElement(Order = -1000000)]
    [JsonProperty(Order = -1000)]
    // [IsUbluxRequired] // cannot have this because sometimes if calling api with null value it will fail
    [UbluxValidationRequired]
    [SwaggerSchema(ReadOnly = true, Nullable = false)]
    [AllowUpdate(false)] // allow update will include property.
                         // This property is needed in order to know what document will be updated
    public string Id
    {
        get => id;
#if UBLUX_Release || RELEASE
        set => id = value;
#endif
    }
    // internal because sometimes we need to set this via unit tests
    internal string id = string.Empty;

    /// <summary>
    ///     Creation date. Sets DateUpdated if it does not have a value
    /// </summary>
    [JsonProperty(Order = 1000)]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    [UbluxValidationRequired]
    public required DateTime DateCreated
    {
        get => dateCreated;
        set
        {
            dateCreated = value;

            // if created date is greater than date updated. Make dateUpdated the same
            if (value > dateUpdated)
                dateUpdated = value;
        }
    }
    private DateTime dateCreated = new ();

    /// <summary>
    ///     Updated date. When item is created on database this date will be set too. This is important so that we can sync contacts
    /// </summary>
    [JsonProperty(Order = 1002)]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    [UbluxValidationRequired]
    // [Obsolete("Just a reminder that when setting the DateCreated it will also set this same value")]    
    public DateTime DateUpdated
    {
        get
        {
            return dateUpdated;
        }
#if UBLUX_Release || RELEASE
        set
        {
            // this must be greater or equal to dateCreated
            dateUpdated = value;
        }
#endif
    }
    private DateTime dateUpdated = new ();

    /// <summary>
    ///     Get MongoDB indexes
    /// </summary>
    public abstract IEnumerable<MongoDbIndex> GetMongoDbIndexes();

    /// <summary>
    ///     Required indexes by all collections
    /// </summary>
    public virtual IEnumerable<MongoDbIndex> GetMandatoryIndexes(Collections collection, int order = 1)
    {
        // Required to sync stuff
        yield return new MongoDbIndex(collection, order, nameof(DateUpdated))
            // Append DateCreated at the end so that items are ordered by DateCreated
            .Add(order, nameof(DateCreated));
    }
}

/// <summary>
///     Ublux document that references an account
/// </summary>
public abstract partial class UbluxDocument_ReferenceAccount : UbluxDocument, IReferencesAccount
{
    /// <summary>
    ///     It is nullable because there are cases where it makes no sense to point to an account. 
    ///     For example a CloudService user will point to no account
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string IdAccount { get; set; } = "";

    /// <summary>
    ///     Required indexes by all collections
    /// </summary>
    public override IEnumerable<MongoDbIndex> GetMandatoryIndexes(Collections collection, int order = 1)
    {
        // get mandatory indexes from base
        foreach (var item in base.GetMandatoryIndexes(collection, order))
            yield return item;

        // enable searching by items of a specific account
        yield return new MongoDbIndex(collection, order, nameof(IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(order, nameof(DateCreated));
    }
}

/// <summary>
///     Ublux document that references an account and have tags
/// </summary>
public abstract partial class UbluxDocument_ReferenceAccount_ReferenceTags : UbluxDocument_ReferenceAccount, IReferencesTags
{
    /// <summary>
    ///     It is nullable because there are cases where it makes no sense to point to an account. 
    ///     For example a CloudService user will point to no account
    /// </summary>
    [References(typeof(Tag))]
    [AllowUpdate(true)]
    public List<string> IdsTags { get; set; } = new();

    /// <summary>
    ///     Required indexes by all collections
    /// </summary>
    public override IEnumerable<MongoDbIndex> GetMandatoryIndexes(Collections collection, int order = 1)
    {
        // get mandatory indexes from base
        foreach (var item in base.GetMandatoryIndexes(collection, order))
            yield return item;

        // Enable searching by specific tags
        yield return new MongoDbIndex(collection, order, nameof(IdsTags))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(order, nameof(DateCreated));
    }
}


