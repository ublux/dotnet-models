namespace Ublux.Communications.Domain;

/// <summary>
///     All objects stored on database must contain this properties
///     T must represent it's mapping DTO
/// </summary>
public abstract class UbluxSubDocument : IUbluxSubDocument
{
    // Todo mark this property on database with unique index

    /// <summary>
    ///     Id of entity
    /// </summary>
    [AllowUpdate(false)] // subdocuments should be updated separately
    [IsRequired]
    [HideForCreateRequest]
    public string Id { get; set; } = String.Empty;

    ///// <inheritdoc />
    //public abstract void SetId();

    ///// <inheritdoc />
    //public abstract string SubDocumentPrefix();


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


    ///// <summary>
    /////     Prefix of subdocument. For example for a Line it will be Li
    ///// </summary>
    //string SubDocumentPrefix();

    ///// <summary>
    /////     Set id of subdocument
    ///// </summary>
    //void SetId();


}
