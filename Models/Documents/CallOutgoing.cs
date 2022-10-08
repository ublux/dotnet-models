namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Outgoing phone call
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlowLogic), nameof(CallType.IncomingToCallFlowLogic))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[BsonKnownTypes(
    //typeof(CallIncomingToCallFlowLogic),
    //typeof(CallIncomingToExtension),
    typeof(CallOutgoingToExtension),
    typeof(CallOutgoingToPSTN)
)]
public abstract partial class CallOutgoing : Call
{
    /// <summary>    
    ///     Contact to whom we are calling
    /// </summary>
    [AllowUpdate(false)]
    public override Contact? Contact { get; set; }

    /// <summary>
    ///     Line that started phone call
    /// </summary>
    [AllowUpdate(false)]
    //[References(typeof(Line))]
    [IsUbluxRequired]
    public required Line LineThatInitiatedCall { get; set; }
}
































