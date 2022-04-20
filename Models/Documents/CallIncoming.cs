namespace Ublux.Communications.Models.Documents;

// ReSharper disable ConditionIsAlwaysTrueOrFalse
/// <summary>
///     Incoming phone call between PSTN and Ublux
/// </summary>
public abstract class CallIncoming : Call
{
    /// <summary>
    ///     This is twilio call id. For example: CA4956d471b581f3202e34bd3582646277
    ///     Thanks to this we can find more info with the provider
    ///     ${SIP_HEADER(X-Twilio-CallSid}
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? ProviderSid { get; set; }

    /// <summary>
    ///     Contact that called    
    /// </summary>
    [AllowUpdate(false)]
    public override Contact? Contact { get; set; }
    
    /// <summary>
    ///     Provider that received and sent us the phone call
    /// </summary>
    [References(typeof(VoipProvider))]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public string IdVoipProvider { get; set; } = String.Empty;

    /// <summary>
    ///     VOIP phone number that received the phone call
    /// </summary>
    [References(typeof(VoipNumberPhone))]
    [AllowUpdate(false)]
    [Required]
    public string IdVoipNumberPhone { get; set; } = String.Empty; // idDID
}