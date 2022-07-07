namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call between PSTN and Ublux
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlow), nameof(CallType.IncomingToCallFlow))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
//[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
//[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[BsonKnownTypes(
    typeof(CallIncomingToCallFlow),
    typeof(CallIncomingToExtension)
//typeof(CallOutgoingToExtension),
//typeof(CallOutgoingToPSTN)
)]
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
    public required string IdVoipNumberPhone { get; set; } // idDID

    /// <summary>
    ///     Phone number that received phone call in international format
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string FromInternationalFormat { get; set; }
}