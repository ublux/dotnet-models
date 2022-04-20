﻿namespace Ublux.Communications.Domain;

/// <summary>
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database. 
///     Business Logic Models that we work with inherit from this. 
///     We need to work with what is stored on our application. 
///     DTO objects is what we present to clients
/// </summary>
public interface IUbluxDocument : IUbluxDocumentId
{
    /// <summary>
    ///     Creation date
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1000)]
    [Required]
    string DateCreated { get; set; }

    /// <summary>
    ///     Date when item was deleted
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1001)]
    [IgnoreDataMember]
    string? DateDeleted { get; set; }

    /// <summary>
    ///     If collection is immutable this is not needed but we have it regardless
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1002)]
    string? DateUpdated { get; set; }

}

/// <summary>
///     * This are business logic objects *
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database
/// </summary>
// ReSharper disable once RedundantExtendsListEntry
public abstract class UbluxDocument : IUbluxDocument, IUbluxDocumentId
{
    /// <summary>
    ///     Id of document
    /// </summary>
    [JsonProperty(Order = -1000, PropertyName = "id")]
    [Required]
    [HideForCreateRequest]
    [AllowUpdate(true)] // allow update will include property.
                        // This property is needed in order to know what document will be updated
    public string _id { get; set; } = String.Empty;

    /// <summary>
    ///     Creation date
    /// </summary>
    [JsonProperty(Order = 1000)]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public string DateCreated { get; set; } = string.Empty;

    /// <summary>
    ///     Deletion Date
    /// </summary>
    [JsonProperty(Order = 1001)]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public string? DateDeleted { get; set; }

    /// <summary>
    ///     Updated date
    /// </summary>
    [JsonProperty(Order = 1002)]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public string? DateUpdated { get; set; }

}

/// <summary>
///     All ublux documents should have this id
/// </summary>
public interface IUbluxDocumentId
{
    /// <summary>
    ///     Id of document
    /// </summary>
    [JsonProperty(Order = -1000, PropertyName = "id")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    [AllowUpdate(true)] // set to true because property id is needed on auto-generated objects    
    [Required]
    [HideForCreateRequest]
    string _id { get; set; }
}

