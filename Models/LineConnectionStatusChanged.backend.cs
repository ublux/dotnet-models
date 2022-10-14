#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Used to sync line connection status changes with WS
/// </summary>
public class LineConnectionStatusChanged
{
    /// <summary>
    ///     Id of line that was modified
    /// </summary>
    [AllowUpdate(false)]    
    public required string IdLine { get; set; } = String.Empty;

    /// <summary>
    ///     Line index
    /// </summary>    
    public int LineIndex { get; set; }

    ///// <summary>
    /////     Id of phone
    ///// </summary>
    //[AllowUpdate(false)]
    //public required string IdPhone { get; set; }

    /// <summary>
    ///     Id of Account
    /// </summary>
    [AllowUpdate(false)]
    public required string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Clone this to avoid sync problems.
    /// </summary>
    [AllowUpdate(false)]
    public required LineConnectionStatus NewLineConnectionStatus { get; set; }
}

#endif