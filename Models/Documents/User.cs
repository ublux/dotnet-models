namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or Admin.
///     If its a PBX user for example it must point to account tbd 27
/// </summary>
[DebuggerDisplay("Username: {Username}")]
[BsonIgnoreExtraElements]
public partial class User : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties   

    #region References

    /// <summary>
    ///     Email of user. This is the Id not the email address.
    ///     Two users may user the same email address.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [References(typeof(Email))]
    public required string IdEmail { get; set; } = string.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    ///     Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify. 
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationIsRequired]
    [BsonRepresentation(BsonType.String)]
    public required List<UbluxRole> UbluxRoles { get; set; } = new();

    #endregion    

    /// <summary>
    ///     What type of user is this? Is this a PBX? WA?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required UserType UserType { get; set; }

    /// <summary>
    ///     Username needed to authenticate. This is usually an email address in lowercase
    ///     If its a PBX/WA then it is the instance id in lowercase
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string Username
    {
        get => (username ?? string.Empty).ToLower();
        set
        {
            if (value == null)
                username = string.Empty;
            else
                username = value.ToLower();
        }
    }
    private string username = string.Empty;

    /// <summary>
    ///     Password needed to authenticate. This is different than the Authorization.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [HideForCreateRequest]
    public required string Password { get; set; } = string.Empty;

    ///// <summary>
    /////     Only allow connections from this regex. Default is "*"
    ///// </summary>
    //[AllowUpdate(true)]
    //public string? AllowConnectingFromIpRegex { get; set; }

    ///// <summary>
    /////     Only allow authentication if ip address stays the same.
    /////     If IpAddressLastAuthenticated is null then this will be allowed.
    ///// </summary>
    //[AllowUpdate(true)]
    //public bool PreventConnectingIfIpChanges { get; set; }

    /// <summary>
    ///     Ip address where it was last authenticated
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public string? IpAddressWhereAuthenticated { get; set; }

    /// <summary>
    ///     Date when this user was last authenticated
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public DateTime? DateAuthenticated { get; set; }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by username this will make authentication faster
        yield return new MongoDbIndex(collection, nameof(this.Username))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));        
    }

    #endregion
}
