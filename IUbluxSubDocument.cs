namespace Ublux.Communications.Models;

/// <summary>
///     MongoDB supports subdocuments
/// </summary>
public abstract class UbluxSubDocument 
{
    // TODO: mark this property on database with unique index

    /// <summary>
    ///     Id of entity
    /// </summary>
    [AllowUpdate(false)] // subdocuments should be updated separately
    [IsRequired]
    [HideForCreateRequest]
    public string Id { get; set; } = String.Empty;
}

