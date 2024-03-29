﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call between PSTN and Ublux
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(CallType))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToCallFlowLogic), nameof(CallType.IncomingToCallFlowLogic))]
[JsonSubtypes.KnownSubType(typeof(CallIncomingToExtension), nameof(CallType.IncomingToExtension))]
//[JsonSubtypes.KnownSubType(typeof(CallOutgoingToExtension), nameof(CallType.OutgoingToExtension))]
//[JsonSubtypes.KnownSubType(typeof(CallOutgoingToPSTN), nameof(CallType.OutgoingToPSTN))]
[BsonKnownTypes(
    typeof(CallIncomingToCallFlowLogic),
    typeof(CallIncomingToExtension)
//typeof(CallOutgoingToExtension),
//typeof(CallOutgoingToPSTN)
)]
public abstract partial class CallIncoming : Call
{
    /// <summary>
    ///     VOIP phone number that received the phone call
    /// </summary>
    [References(typeof(VoipNumberPhone))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? IdVoipNumberPhone { get; set; }  // may be null if gateway call

    /// <summary>
    ///     Phone number that received phone call in international format
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required string FromInternationalFormat { get; set; } = string.Empty;

    /// <summary>
    ///     Providers send us the information if call is being forwarded. It may be helpful to store this.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ForwardedBy { get; set; }
}