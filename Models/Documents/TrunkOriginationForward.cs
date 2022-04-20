namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     This type of trunk origination forwards the call to our pbx. Twilio uses this type of Trunk origination
/// </summary>
public partial class TrunkOriginationForward : TrunkOrigination
{
    /// <summary>
    ///     Url where to forward traffic
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public string SipUri { get; set; } = string.Empty;

    /// <summary>
    ///     Sip URI where to send traffic in case primary SipUri fails
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public string SipUriFailover { get; set; } = string.Empty;
    

    /// <summary>
    ///     Type of trunk origination
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    [HideForCreateRequest]
    public override TrunkOriginationType TrunkOriginationType => TrunkOriginationType.Forward;
}
