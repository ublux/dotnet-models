namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Only users can have api keys. Everyone else should have a JWT
/// </summary>
public partial class ApiKey : UbluxDocument, IReferencesTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> IdsTags { get; set; } = new();

    /// <summary>
    ///     Identity that created this key. 
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)]
    [References(typeof(Identity))]
    public required string IdIdentity { get; set; } = string.Empty;

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
    [IgnoreDataMember]
    public required string Key { get; set; } = string.Empty;

    /// <summary>
    ///     Date last authenticated
    /// </summary>
    [AllowUpdate(false)]
    public DateTime? DateLastUsed { get; set; }

    #endregion
}
