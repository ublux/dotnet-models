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
    [IsRequired]
    [HideForCreateRequest]
    public string IdAccount { get; set; } = String.Empty;
}

#endif