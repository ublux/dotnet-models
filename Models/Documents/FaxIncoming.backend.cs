#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming fax
/// </summary>
public partial class FaxIncoming : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [References(typeof(Account))]
    [IsRequired]
    public required string IdAccount { get; set; }
}

#endif