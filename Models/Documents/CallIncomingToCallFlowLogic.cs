namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call that executed an IVR
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallIncomingToCallFlowLogic : CallIncoming
{
    /// <summary>
    ///     Id of Call Flow (IVR) to execute
    /// </summary>
    [References(typeof(CallFlowLogic))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public required string IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public override CallType CallType
    {
        get => CallType.IncomingToCallFlowLogic;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}