#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux Account
/// </summary>
public partial class Account : UbluxDocument
{
    #region References

    /// <summary>
    ///     Failover pbx that will be used for account
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(CloudServicePbx))]
    [IsRequired]
    public string IdCloudServicePbxFailover { get; set; } = String.Empty;

    ///// <summary>
    /////     Reference to webAppCloudService. Thanks to this we know where to send events. For example on pbx when we receive a new phone call we send that event to CloudServicePbx
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //[References(typeof(CloudServiceWebApp))]
    //[IsRequired]
    //public string IdCloudServiceWebApp { get; set; } = String.Empty;

    /// <summary>
    ///     Trunks that will be used for outgoing calls ordered by priority. Points to collection Group_TrunkTerminations
    ///     Reference to another entity on database. 
    ///     Example: GP-CANALPARK-PRODUCTION-1
    ///     
    ///     ON PBX THIS CONTAINS THE IDS SEPARATED BY COMMA. When pbx requests for Accounts WS will modify this property and perform the join
    ///     Example: Production-CanalPark-Twilio-US-1,Production-CanalPark-Netbox-MX-1,Production-CanalPark-Netbox-All-1
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(TrunkTerminationGroup))]
    [AllowUpdate(false)]
    [IsRequired]
    public string IdGTrunkTerminationGroup { get; set; } = String.Empty;


    #endregion

    /// <summary>
    ///     Continental assists has 2 providers on their phones.
    ///     Thanks to this Variable we may ignore an account so that we do not override properties from Netelip for example.
    ///
    ///     For example value {3,4} will reserver accounts 3 and 4 for personal use of Continental assist
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public List<int> ReserveAccountsOnPhone { get; set; } = new();

    /// <summary>
    ///     Was this account sold by CanalPark, Victor, Daniel?
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public UbluxPartner UbluxPartner { get; set; }
}

#endif


