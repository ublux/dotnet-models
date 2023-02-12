#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public partial class WebHook : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public required string IdAccount { get; set; } = "";

    #endregion
}

#endif