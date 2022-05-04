namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Tokens that are not authorized. Perhaps a token has been stolen
/// </summary>
public partial class UnauthorizedToken : UbluxDocument, IReferncesAccount
{
    // id is the last 16 characters of JWT

    /// <summary>
    ///     Full token
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string Jwt { get; set; } = string.Empty;

    /// <summary>
    ///     Id user
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Identity))]
    [IsRequired]
    public string IdIdentity { get; set; } = string.Empty;

    /// <summary>
    ///     Date when JWT expires
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public DateTime ExpirationDate { get; set; }
}
