namespace Ublux.Communications.Models;

/// <summary> 
///     Session is a logged in Identity (user). We use JWT Security tokens to store this Session.
/// </summary>
public partial class UbluxSession 
{
    /// <summary> sub property from JWT. Logged in by what user? This may be a PBX </summary>
    [References(typeof(Identity))]
    [IsUbluxRequired]
    [AllowUpdate(false)]
    public required string IdIdentity { get; set; }

    /// <summary>
    ///     aud property from JWT. Audience identity type
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)]
    public required IdentityType IdentityType { get; set; }

    /// <summary>
    ///     acc property from JWT. Id of account. This is not a backend field
    /// </summary>
    [References(typeof(Account))]
    [IsUbluxRequired]
    [AllowUpdate(false)]
    public required string IdAccount { get; set; } = String.Empty;

    ///// <summary>
    /////     Ids of tags
    ///// </summary>
    //[AllowUpdate(true)]
    //[References(typeof(Tag))]
    //public List<string> Tags { get; set; } = new();

    /// <summary>
    ///     role properties from JWT. Permissions
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)]
    [BsonRepresentation(BsonType.String)]
    public required List<UbluxRole> UbluxRoles { get; set; }

    /// <summary> exp property from JWT. Date when session expires </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)]
    public required DateTime ExpirationDate { get; set; }
}

