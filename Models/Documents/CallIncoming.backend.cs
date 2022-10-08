#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call between PSTN and Ublux
/// </summary>
public abstract partial class CallIncoming : Call
{
    ///// <summary>
    /////     This is twilio call id. For example: CA4956d471b581f3202e34bd3582646277
    /////     Thanks to this we can find more info with the provider
    /////     ${SIP_HEADER(X-Twilio-CallSid}
    ///// </summary>
    //[AllowUpdate(false)]
    //[IgnoreDataMember]
    //public string? ProviderSid { get; set; }

    /// <summary>
    ///     Provider that received and sent us the phone call
    /// </summary>
    [References(typeof(VoipProvider))]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required string IdVoipProvider { get; set; }
}

#endif