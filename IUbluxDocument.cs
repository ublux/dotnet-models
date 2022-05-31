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
    [JsonProperty(Order = 1000)]
    [IsRequired]
    DateTime DateCreated { get; set; }

    /// <summary>
    ///     If collection is immutable this is not needed but we have it regardless
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1002)]
    DateTime? DateUpdated { get; set; }
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
    [IsRequired]
    [HideForCreateRequest]
    [AllowUpdate(true)] // allow update will include property.
                        // This property is needed in order to know what document will be updated
    public string Id
    {
        get => id;
#if UBLUX_BACKEND
        [Obsolete($"Set via {nameof(BuiltId)}")]
#endif
        init => id = value;
    }
    private string id = String.Empty;
    
    /// <summary>
    ///     Creation date
    /// </summary>
    [JsonProperty(Order = 1000)]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public DateTime DateCreated { get; set; }

    /// <summary>
    ///     Updated date
    /// </summary>
    [JsonProperty(Order = 1002)]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public DateTime? DateUpdated { get; set; }
}
