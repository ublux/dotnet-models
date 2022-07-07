namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call that executed an IVR
/// </summary>
public partial class CallIncomingToCallFlow : CallIncoming
{
    /// <summary>
    ///     Id of Call Flow (IVR) to execute
    /// </summary>
    [References(typeof(CallFlow))]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdCallFlow { get; set; }

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    public override CallType CallType => CallType.IncomingToCallFlow;
}