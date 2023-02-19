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
    //[BsonRepresentation(BsonType.ObjectId)]
    [BsonRepresentation(BsonType.String)] // store id as string
    [JsonProperty(Order = -1000)]
    [BsonElement(Order = -1000000)]
    [AllowUpdate(true)] // set to true because property id is needed on auto-generated objects    
    [IsUbluxRequired]
    [HideForCreateRequest]
    [SwaggerSchema(ReadOnly = true)]
    string Id { get; init; }
}
