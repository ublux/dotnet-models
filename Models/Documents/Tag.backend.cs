#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Category
/// </summary>
public partial class Tag : UbluxDocument, IReferncesAccount
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
