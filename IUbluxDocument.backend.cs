#if UBLUX_BACKEND

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ublux.Communications.WS.IntegrationTests")]


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
    ///     Date when item was deleted
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1001)]
    [IgnoreDataMember]
    DateTime? DateDeleted { get; set; }
}

/// <summary>
///     * This are business logic objects *
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database
/// </summary>
public abstract partial class UbluxDocument : IUbluxDocument, IUbluxDocumentId
{
    /// <summary>
    ///     Only used in unit tests
    /// </summary>
    internal void UnitTest_SetId(string id)
    {
        this.id = id;
    }

    /// <summary>
    ///     Set id
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    [BsonIgnore]
    [JsonIgnore]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public required BuiltId BuiltId
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
    [HideForCreateRequest]
    public DateTime? DateDeleted { get; set; }
    
    
}

#endif