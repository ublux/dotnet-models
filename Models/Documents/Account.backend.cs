#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux Account
/// </summary>
public partial class Account : UbluxDocument
{
    #region References

    ///// <summary>
    /////     Failover pbx that will be used for account
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    // [SwaggerSchema(ReadOnly = true)]
    //[References(typeof(CloudServicePbx))]
    //[IsUbluxRequired]
    //public required string IdCloudServicePbxFailover { get; set; } = string.Empty;

    ///// <summary>
    /////     Reference to webAppCloudService. Thanks to this we know where to send events. For example on pbx when we receive a new phone call we send that event to CloudServicePbx
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    // [SwaggerSchema(ReadOnly = true)]
    //[References(typeof(CloudServiceWebApp))]
    //[IsUbluxRequired]
    //public required string IdCloudServiceWebApp { get; set; } = string.Empty;

    /// <summary>
    ///     Trunks that will be used for outgoing calls ordered by priority. Points to collection Group_TrunkTerminations
    ///     Reference to another entity on database. 
    ///     Example: GP-CANALPARK-PRODUCTION-1
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(TrunkTerminationGroup))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string IdGTrunkTerminationGroup { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     Continental assists has 2 providers on their phones.
    ///     Thanks to this Variable we may ignore an account so that we do not override properties from Netelip for example.
    ///
    ///     For example value {3,4} will reserver accounts 3 and 4 for personal use of Continental assist
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public List<int> ReserveAccountsOnPhone { get; set; } = new();

    /// <summary>
    ///     Was this account sold by CanalPark, Victor, Daniel?
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public UbluxPartner UbluxPartner { get; set; }

    /// <summary>
    ///     Id of account where phones that are TBD connect.
    /// </summary>
    public static BuiltId IdTbdCase27 = Account.BuildId("27");
}

#endif


