namespace Ublux.Communications.Models;

/// <summary> 
///     Session is a logged in Identity (user). We use JWT Security tokens to store this Session.
/// </summary>
public partial class UbluxSession
{
    /// <summary> sub property from JWT. Logged in by what user? This may be a PBX </summary>
    [References(typeof(Identity))]
    [IsRequired]
    [AllowUpdate(false)]
    public required string IdIdentity { get; set; }

    /// <summary>
    ///     aud property from JWT. Audience identity type
    /// </summary>
    [IsRequired]
    [AllowUpdate(false)]
    public required IdentityType IdentityType { get; set; }

    /// <summary>
    ///     acc property from JWT. Id of account
    /// </summary>
    [References(typeof(Account))]
    [IsRequired]
    [AllowUpdate(false)]
    public required string IdAccount { get; set; }

    /// <summary>
    ///     role properties from JWT. Permissions
    /// </summary>
    [IsRequired]
    [AllowUpdate(false)]
    [BsonRepresentation(BsonType.String)]
    public required List<UbluxRole> UbluxRoles { get; set; }

    /// <summary> exp property from JWT. Date when session expires </summary>
    [IsRequired]
    [AllowUpdate(false)]
    public required DateTime ExpirationDate { get; set; }
}

