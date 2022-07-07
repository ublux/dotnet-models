namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Tokens that are not authorized. Perhaps a token has been stolen
/// </summary>
public partial class UnauthorizedToken : UbluxDocument
{
    // id is the last 16 characters of JWT

    /// <summary>
    ///     Full token
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string Jwt { get; set; }

    /// <summary>
    ///     Id user
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Identity))]
    [IsRequired]
    public required string IdIdentity { get; set; }

    /// <summary>
    ///     Date when JWT expires
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required DateTime ExpirationDate { get; set; }
}
