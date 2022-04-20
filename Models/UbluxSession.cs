namespace Ublux.Communications.Models;

/// <summary> 
///     Session is a logged in Identity (user). We use JWT Security tokens to store this Session.
/// </summary>
public class UbluxSession : IReferncesAccount
{
    /// <summary> sub property from JWT. Logged in by what user? This may be a PBX </summary>
    [References(typeof(Identity))]
    [Required]
    [AllowUpdate(false)]
    public string IdIdentity { get; set; } = String.Empty;

    /// <summary>
    ///     aud property from JWT. Audience identity type
    /// </summary>
    [Required]
    [AllowUpdate(false)]
    public IdentityType IdentityType { get; set; }

    /// <summary>
    ///     acc property from JWT. Id of account
    /// </summary>
    [References(typeof(Account))]
    [Required]
    [AllowUpdate(false)]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     role properties from JWT. Permissions
    /// </summary>
    [Required]
    [AllowUpdate(false)]
    [BsonRepresentation(BsonType.String)]
    public List<UbluxRole> UbluxRoles
    {
        get => _UbluxRoles;
        set { if (value is null) _UbluxRoles.Clear(); else _UbluxRoles = value; }
    }
    List<UbluxRole> _UbluxRoles = new();

    // Use long variable because we store this on database
    /// <summary> exp property from JWT. Date when session expires </summary>
    [Required]
    [AllowUpdate(false)]
    public string ExpirationDate { get; set; } = string.Empty;

}

