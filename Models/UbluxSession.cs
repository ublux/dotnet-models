namespace Ublux.Communications.Models;

/// <summary> 
///     Session is a logged in User (user). We use JWT Security tokens to store this Session.
/// </summary>
public partial class UbluxSession 
{
    /// <summary> sub property from JWT. Logged in by what user? This may be a PBX </summary>
    [References(typeof(User))]
    [IsUbluxRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string IdUser { get; set; }

    /// <summary>
    ///     aud property from JWT. Audience user type
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required UserType UserType { get; set; }

    /// <summary>
    ///     acc property from JWT. Id of account. This is not a backend field
    /// </summary>
    [References(typeof(Account))]
    [IsUbluxRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string IdAccount { get; set; } = String.Empty;

    ///// <summary>
    /////     Ids of tags
    ///// </summary>
    //[AllowUpdate(true)]
    //[References(typeof(Tag))]
    //public List<string> IdsTags { get; set; } = new();

    /// <summary>
    ///     role properties from JWT. Permissions
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [BsonRepresentation(BsonType.String)]
    public required List<UbluxRole> UbluxRoles { get; set; }

    /// <summary> exp property from JWT. Date when session expires </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required DateTime ExpirationDate { get; set; }
}

