#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Tokens that are not authorized. Perhaps a token has been stolen
/// </summary>
public partial class UnauthorizedToken : UbluxDocument, IReferncesAccount
{
    /// <summary>
    ///     Id of account
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;
}

#endif