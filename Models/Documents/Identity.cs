namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
public partial class Identity : UbluxDocument
{
    // id should be the username/email

    #region Properties

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
    ///     Username needed to authenticate. This is usually an email address in lowercase
    ///     If its a PBX then it is the instance id
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
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
    [IsUbluxRequired]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public required string Password { get; set; }

    /// <summary>
    ///     What type of user is this? Is this a PBX? WA?
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest] // remember to add this on admin service!
    // virtual because of unit tests so that it can mock this object
    public required IdentityType IdentityType { get; set; }

    /// <summary>
    ///     Only allow connections from this regex. Default is "*"
    /// </summary>
    [AllowUpdate(true)]
    // virtual because of unit tests so that it can mock this object
    public virtual string? AllowConnectingFromIpRegex { get; set; }

    /// <summary>
    ///     Only allow authentication if ip address stays the same.
    ///     If IpAddressLastAuthenticated is null then this will be allowed.
    /// </summary>
    [AllowUpdate(true)]
    // virtual because of unit tests so that it can mock this object
    public virtual bool PreventConnectingIfIpChanges { get; set; }

    /// <summary>
    ///     Ip address where it was last authenticated
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public virtual string? IpAddressWhereAuthenticated { get; set; }
    // virtual because of unit tests so that it can mock this object

    /// <summary>
    ///     Date when this user was last authenticated
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public virtual DateTime? DateAuthenticated { get; set; }

    #endregion
}
