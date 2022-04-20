namespace Ublux.Communications.Domain;

/// <summary>
///     All objects stored on database must contain this properties
///     T must represent it's mapping DTO
/// </summary>
public abstract class UbluxSubDocument : IUbluxSubDocument
{
    // todo make this unique key on database 

    /// <summary>
    ///     Id of entity
    /// </summary>
    [AllowUpdate(false)] 
    [Required]
    [HideForCreateRequest]
    public string Id { get; set; } = String.Empty;
}

/// <summary>
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database
/// </summary>
public interface IUbluxSubDocument 
{
    ///// <summary>
    /////     Session token
    ///// </summary>
    //[AllowUpdate(false)]
    //[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    //    //string? _id { get; set; }

    /// <summary>
    ///     Id of entity
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public string Id { get; set; } 




}
