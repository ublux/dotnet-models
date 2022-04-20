namespace Ublux.Communications.Domain.Models;

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
    public string IdCallFlow { get; set; } = string.Empty;
}


