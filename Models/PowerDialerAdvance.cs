namespace Ublux.Communications.Models;

/// <summary>
///     Power dialer that executes an IVR
/// </summary>
public class PowerDialerAdvance : PowerDialer
{
    /// <summary>
    ///     IVR to execute
    /// </summary>
    [IsRequired]
    [AllowUpdate(true)]
    public required string IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Type of power dialer
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public override PowerDialerType PowerDialerType => PowerDialerType.Advanced;
}
