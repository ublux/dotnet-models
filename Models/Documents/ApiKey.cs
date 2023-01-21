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
    public List<string> Tags { get; set; } = new();

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
    ///     Date when this user was last authenticated
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public virtual DateTime? DateAuthenticated { get; set; }

    #endregion
}
