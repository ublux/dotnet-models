namespace Ublux.Communications.Models;

/// <summary> 
///     Session is a logged in User (user). We use JWT Security tokens to store this Session.
/// </summary>
public class UbluxSession 
{
    /// <summary> sub property from JWT. Logged in by what user? This may be a CloudService </summary>
    [References(typeof(User))]
    [UbluxValidationRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string IdUser { get; set; }

    /// <summary>
    ///     aud property from JWT. Audience user type
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required UserType UserType { get; set; }

    /// <summary>
    ///     acc property from JWT. Id of account. 
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string IdAccount { get; set; }

    /// <summary>
    ///     role properties from JWT. Permissions
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [BsonRepresentation(BsonType.String)]
    public required List<UbluxRole> UbluxRoles { get; set; }

    /// <summary> exp property from JWT. Date when session expires </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required DateTime ExpirationDate { get; set; }

    /// <summary>
    ///     Is expired
    /// </summary>
    public bool IsExpired() => DateTime.UtcNow > this.ExpirationDate;
}

