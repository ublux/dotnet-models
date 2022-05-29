namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Outgoing phone call
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlow), nameof(CallType.IncomingToCallFlow))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[BsonKnownTypes(
    //typeof(CallIncomingToCallFlow),
    //typeof(CallIncomingToExtension),
    typeof(CallOutgoingToExtension),
    typeof(CallOutgoingToPSTN)
)]
public abstract class CallOutgoing : Call
{
    /// <summary>    
    ///     Contact to whom we are calling
    /// </summary>
    [AllowUpdate(false)]
    public override Contact? Contact { get; set; }

    /// <summary>
    ///     Id line that started phone call
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Line))]
    [IsRequired]
    public string IdLineThatInitiatedCall { get; set; } = string.Empty;
}
































