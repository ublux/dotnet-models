#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents; 

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
    [IsRequired]
    public string SipUri { get; set; } = string.Empty;

    /// <summary>
    ///     Sip URI where to send traffic in case primary SipUri fails
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public string SipUriFailover { get; set; } = string.Empty;


    /// <summary>
    ///     Type of trunk origination
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    [HideForCreateRequest]
    public override TrunkOriginationType TrunkOriginationType => TrunkOriginationType.Forward;

}

#endif
