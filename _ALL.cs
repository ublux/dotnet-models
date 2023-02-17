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
    [IsUbluxRequired]
    DateTime DateCreated { get; set; }

    /// <summary>
    ///     If collection is immutable this is not needed but we have it regardless
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [JsonProperty(Order = 1002)]
    DateTime DateUpdated { get; set; }
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
    [BsonElement(Order = -1000000)]
    [JsonProperty(Order = -1000)]
    // [IsUbluxRequired]
    // [HideForCreateRequest]
    [SwaggerSchema(ReadOnly = true, Nullable = false)]
    [AllowUpdate(false)] // allow update will include property.
                         // This property is needed in order to know what document will be updated
    public string Id
    {
        get => id;
#if UBLUX_BACKEND
        [Obsolete($"Set via {nameof(BuiltId)}")]
#endif
        init => id = value;
    }
    private string id = string.Empty;

    /// <summary>
    ///     Creation date. Sets DateUpdated if it does not have a value
    /// </summary>
    [JsonProperty(Order = 1000)]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
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
    private DateTime dateCreated;

    /// <summary>
    ///     Updated date. When item is created on database this date will be set too. This is important so that we can sync contacts
    ///     TODO: Very important to place index in this field. 
    /// </summary>
    [JsonProperty(Order = 1002)]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    // [Obsolete("Just a reminder that when setting the DateCreated it will also set this same value")]    
    public DateTime DateUpdated
    {
        get
        {
            return dateUpdated;
        }
        set
        {
            // this must be greater or equal to dateCreated
            dateUpdated = value;
        }
    }
    private DateTime dateUpdated;
}

/// <summary>
///     Ublux document that references an account
/// </summary>
public abstract partial class UbluxDocument_ReferenceAccount : UbluxDocument, IReferncesAccount
{
    /// <summary>
    ///     It is nullable because there are cases where it makes no sense to point to an account. 
    ///     For example a CloudService user will point to no account
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = "";
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
    public List<string> IdsTags { get; set; } = new ();
}


