#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Virtual receptionist
/// </summary>
public partial class CallFlow : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdAccount { get; set; }
}

#endif