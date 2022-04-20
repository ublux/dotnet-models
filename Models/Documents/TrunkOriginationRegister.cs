namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     This type of trunk origination we must register with provider in order to receive phone calls
/// </summary>
public partial class TrunkOriginationRegister : TrunkOrigination
{
    /* Example of what we have to add on sip.conf on region

        register => 525587894423:password@208.89.104.161:5060/525587894423

[525587894423]
type=peer
dtmfmode=rfc2833
context=trunkincoming
qualify=yes
insecure=invite
host=208.89.104.161
username=525587894423
secret=l3tm3inUblux
nat=yes
disallow=all
allow=ulaw
allow=alaw
     */

    /// <summary>
    ///     Registration username
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string Reg_username { get; set; } = string.Empty;

    /// <summary>
    ///     Registration password
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string Reg_password { get; set; } = string.Empty;

    /// <summary>
    ///     Registration host
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string Reg_host { get; set; } = string.Empty;

    /// <summary>
    ///     Registration port
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public int Reg_port { get; set; }

    ///// <summary>
    /////     Example: US-1. On what pbx we will receive phone calls
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //[References(typeof(CloudServicePbx))]
    //public string? Reg_url { get; set; }

    /// <summary>
    ///     Type of trunk origination
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    [HideForCreateRequest]
    public override TrunkOriginationType TrunkOriginationType => TrunkOriginationType.Register;

    // todo check status. For example if trunk is not registered then register on failover pbx
}