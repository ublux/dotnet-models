#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming fax
/// </summary>
public partial class FaxIncoming : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc />
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? IdAccount { get; set; }
}

#endif