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
    public string IdLine { get; set; } = string.Empty;

    /// <summary>
    ///     Line index
    /// </summary>
    public int LineIndex { get; set; }

    ///// <summary>
    /////     Id of phone
    ///// </summary>
    //[AllowUpdate(false)]
    //public string IdPhone { get; set; } = string.Empty;

    /// <summary>
    ///     Id of Account
    /// </summary>
    [AllowUpdate(false)]
    public string IdAccount { get; set; } = string.Empty;

    /// <summary>
    ///     Clone this to avoid sync problems.
    /// </summary>
    [AllowUpdate(false)]
    public LineConnectionStatus NewLineConnectionStatus { get; set; } = new ();
}

#endif