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
    [SwaggerSchema(ReadOnly = true)]
    //[IsUbluxRequired]
    //[HideForCreateRequest]
    public string Id
    {
        get => id;
#if UBLUX_Release || RELEASE
        set => id = value;
#endif
    }
    private string id = string.Empty;

}

