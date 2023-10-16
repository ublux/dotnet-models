#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database. 
///     Business Logic Models that we work with inherit from this. 
///     We need to work with what is stored on our application. 
///     DTO objects is what we present to clients
/// </summary>
public partial interface IUbluxDocument 
{
    /// <summary>
    ///     Date when item was deleted
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [JsonProperty(Order = 1001)]
    [IgnoreDataMember]
    DateTime? DateDeleted { get; set; }
}

/// <summary>
///     * This are business logic objects *
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database
/// </summary>
public abstract partial class UbluxDocument 
{
    /// <summary>
    ///     We need to use a lock because we store a lot of data on the cache. 
    ///     There is the possibility that the same object is attempted to be modified at the same time.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once MemberCanBePrivate.Global
    protected readonly ReaderWriterLockSlim _lock = new();

    /// <summary>
    ///     Set id
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    [BsonIgnore]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public
#if UBLUX_Release || RELEASE
#else
        required 
#endif
    BuiltId BuiltId
    {
        set
        {
            this.id = value.Id;
        }
    }

    /// <summary>
    ///     Deletion Date
    /// </summary>
    [JsonProperty(Order = 1001)]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public DateTime? DateDeleted
    {
        get { try { _lock.EnterReadLock(); return _dateDeleted; } finally { _lock.ExitReadLock(); } }
        set { try { _lock.EnterWriteLock(); _dateDeleted = value; } finally { _lock.ExitWriteLock(); } }
    }
    private DateTime? _dateDeleted;      
}
/*

 */

#endif