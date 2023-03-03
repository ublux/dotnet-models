#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     This type of trunk origination forwards the call to our pbx. Twilio uses this type of Trunk origination
/// </summary>
public partial class TrunkOriginationForward : TrunkOrigination
{
    // Id = "{Provider}:{Name}"
    // example: Twilio-CanalPark:UST
    // can have the same id as trunk termination!

    /// <summary>
    ///     Url where to forward traffic
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required string SipUri { get; set; } = string.Empty;

    /// <summary>
    ///     Sip URI where to send traffic in case primary SipUri fails
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required string SipUriFailover { get; set; } = string.Empty;

    /// <summary>
    ///     Type of trunk origination
    /// </summary>
    [AllowUpdate(false)]
    // [IgnoreDataMember] if ignored deserialization will not work
    [IsUbluxRequired]
    [HideForCreateRequest]
    public override TrunkOriginationType TrunkOriginationType
    {
        get => TrunkOriginationType.Forward;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}

#endif
