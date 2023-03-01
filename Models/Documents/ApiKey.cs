namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Only users can have api keys. Everyone else should have a JWT
/// </summary>
[BsonIgnoreExtraElements]
public partial class ApiKey : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References    

    /// <summary>
    ///     User that created this key. 
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(User))]
    public required string IdUser { get; set; } = string.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    ///     Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify. 
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)]
    public required List<UbluxRole> UbluxRoles { get; set; }

    #endregion    

    /// <summary>
    ///     Api key
    ///     TODO place index on database on this field
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public required string Key { get; set; } = string.Empty;

    /// <summary>
    ///     If null it will never expire. Else it will have an expiration
    /// </summary>
    [AllowUpdate(true)]
    public DateTime? DateExpire { get; set; }

    /// <summary>
    ///     Date last authenticated
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateLastUsed { get; set; }

    ///// <summary>
    /////     If true it will be marked as deleted after it was used
    ///// </summary>
    //[AllowUpdate(true)]
    //public bool UseOnce { get; set; }

    /// <summary>
    ///     Description or notes of API key
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }    

    #endregion
}
