#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.Documents; 

/// <summary>
///     SMS message
/// </summary>
public partial class SMS : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Account))]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;

    #endregion
}

#endif