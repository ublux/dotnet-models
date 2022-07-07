#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Configuration of a phone
/// </summary>
public partial class PhoneConfiguration : UbluxDocument, IReferncesAccount
{

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdAccount { get; set; }

}

#endif