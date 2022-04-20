namespace Ublux.Communications.Models;

/// <summary>
///     Power dialer that executes an IVR
/// </summary>
public class PowerDialerAdvance : PowerDialer
{
    /// <summary>
    ///     IVR to execute
    /// </summary>
    [Required]
    [AllowUpdate(true)]
    public string IdCallFlow { get; set; } = string.Empty;
}


