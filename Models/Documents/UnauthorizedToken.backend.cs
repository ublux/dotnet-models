#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Tokens that are not authorized. Perhaps a token has been stolen
/// </summary>
public partial class UnauthorizedToken : UbluxDocument, IReferncesAccount
{
    /// <summary>
    ///     Id of account
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? IdAccount { get; set; }
}

#endif