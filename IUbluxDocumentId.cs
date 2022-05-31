namespace Ublux.Communications.Models;

/// <summary>
///     All ublux documents should have this id
/// </summary>
public interface IUbluxDocumentId
{
    /// <summary>
    ///     Id of document
    /// </summary>
    [BsonId]
    [JsonProperty(Order = -1000)]
    [BsonElement(Order = -1000000)]
    [AllowUpdate(true)] // set to true because property id is needed on auto-generated objects    
    [IsRequired]
    [HideForCreateRequest]
    string Id { get; init; }
}
