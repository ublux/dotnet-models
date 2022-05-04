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
    public string IdCallFlow { get; set; } = String.Empty;

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    public override CallType CallType => CallType.IncomingToCallFlow;
}