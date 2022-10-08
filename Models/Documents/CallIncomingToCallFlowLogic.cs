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
    [IsUbluxRequired]
    public required string IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    public override CallType CallType => CallType.IncomingToCallFlowLogic;
}