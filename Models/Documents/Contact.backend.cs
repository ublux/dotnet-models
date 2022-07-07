#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Contact
/// </summary>
public partial class Contact : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdAccount { get; set; }
}

#endif