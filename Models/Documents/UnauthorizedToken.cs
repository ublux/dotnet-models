namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
    [Required]
    public string Jwt { get; set; } = string.Empty;

    /// <summary>
    ///     Id user
    /// </summary>
        [AllowUpdate(false)]
    [References(typeof(Identity))]
    [Required]
    public string IdIdentity { get; set; } = string.Empty;

    /// <summary>
    ///     Date when JWT expires
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public string ExpirationDate { get; set; } = String.Empty;

    /// <summary>
    ///     Id of account
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    
}
