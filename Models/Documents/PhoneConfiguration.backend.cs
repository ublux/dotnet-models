#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;
}

#endif