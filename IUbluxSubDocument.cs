namespace Ublux.Communications.Models;

/// <summary>
///     MongoDB supports subdocuments
/// </summary>
public abstract partial class UbluxSubDocument
{

    // TODO: mark this property on database with unique index

    /// <summary>
    ///     Id of entity
    /// </summary>
    [AllowUpdate(false)] // subdocuments should be updated separately
    [IsUbluxRequired]
    [HideForCreateRequest]
    public string Id
    {
        get => id;
#if UBLUX_BACKEND
        [Obsolete("Use SetId method. Do not set manually")]
#endif
        set => id = value;
    }
    private string id = string.Empty;

}

