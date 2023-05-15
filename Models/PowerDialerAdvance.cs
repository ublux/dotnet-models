namespace Ublux.Communications.Models;

/// <summary>
///     Power dialer that executes an IVR
/// </summary>
public class PowerDialerAdvance : PowerDialer
{
    /// <summary>
    ///     IVR to execute
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public required string IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Type of power dialer
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public override PowerDialerType PowerDialerType
    {
        get => PowerDialerType.Advanced;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
