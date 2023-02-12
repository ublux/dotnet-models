#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Multiple audios to be used as music on hold
/// </summary>
public partial class MusicOnHoldGroup : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    [HideForCreateRequest]
    public required string IdAccount { get; set; } = String.Empty;
}

#endif