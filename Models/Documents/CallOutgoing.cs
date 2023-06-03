namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Outgoing phone call
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlowLogic), nameof(CallType.IncomingToCallFlowLogic))]
//[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPowerDialer), nameof(CallType.PowerDialer))]
[BsonKnownTypes(
    //typeof(CallIncomingToCallFlowLogic),
    //typeof(CallIncomingToExtension),
    typeof(CallOutgoingToExtension),
    typeof(CallOutgoingToPSTN),
    typeof(CallOutgoingToPowerDialer)
)]
public abstract partial class CallOutgoing : Call
{
    ///// <summary>    
    /////     Contact to whom we are calling
    ///// </summary>
    //[AllowUpdate(false)]
    //[References(typeof(Contact))]
    //public override string? IdContact { get; set; }

    /// <summary>
    ///     Line that started phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Line))]
    [UbluxValidationRequired]
    public required string IdLineThatInitiatedCall { get; set; } = string.Empty;
}