#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents; 

/// <summary>
///     Group of line keys
/// </summary>
public partial class LineKeyGroup : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public required string IdAccount { get; set; }
}

#endif