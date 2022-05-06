namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call between PSTN and Ublux
/// </summary>
public abstract partial class CallIncoming : Call
{
    /// <summary>
    ///     Contact that called    
    /// </summary>
    [AllowUpdate(false)]
    public override Contact? Contact { get; set; }

    /// <summary>
    ///     VOIP phone number that received the phone call
    /// </summary>
    [References(typeof(VoipNumberPhone))]
    [AllowUpdate(false)]
    [IsRequired]
    public string IdVoipNumberPhone { get; set; } = String.Empty; // idDID

    /// <summary>
    ///     Phone number that received phone call in international format
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string FromInternationalFormat { get; set; } = String.Empty;
}