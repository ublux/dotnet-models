namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
[DebuggerDisplay("_id:{_id} IdAccount:{IdAccount} IdentityType:{IdentityType}")]
public partial class Identity : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <summary>
    ///     If value is "0" or null it means it can use multiple accounts. For example a PBX identity can be used by multiple accounts.
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Account))]
    [IgnoreDataMember]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public virtual string IdAccount { get; set; } = String.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    ///     Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify. 
    /// </summary>
    [AllowUpdate(true)]
        [Required]
    [BsonRepresentation(BsonType.String)]
    public List<UbluxRole> UbluxRoles
    {
        get => _UbluxRoles;
        set { if (value is null) _UbluxRoles.Clear(); else _UbluxRoles = value; }
    }
    List<UbluxRole> _UbluxRoles = new();



    #endregion

    /// <summary>
    ///     Username needed to authenticate. This is usually an email address in lowercase
    /// </summary>
    [AllowUpdate(false)]
        [Required]
    public string Username
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
        [Required]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public virtual string Password { get; set; } = string.Empty;

    /// <summary>
    ///     What type of user is this? Is this a PBX? WA?
    /// </summary>
    [AllowUpdate(false)]
        [Required]
    [HideForCreateRequest] // remember to add this on admin service!
    // virtual because of unit tests so that it can mock this object
    public virtual IdentityType IdentityType { get; set; }

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
    public virtual string? DateAuthenticated { get; set; }

    #endregion

}
