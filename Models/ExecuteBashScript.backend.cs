#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Models;

/// <summary>
///     Sends as SNS
/// </summary>
public class ExecuteBashScript
{
    /// <summary>
    ///     Wait for output. Try to avoid this as pbx can consume one message at a time.
    /// </summary>
    public bool WaitForOutput { get; set; } = false;

    /// <summary>
    ///     Wiat maximum of 10 seconds
    /// </summary>
    public int WaitForOutputTimeout { get; set; } = 10_000;

    /// <summary>
    ///     Capture standard output?
    /// </summary>
    public bool CaptureStdOutput { get; set; } = true;     

    /// <summary>
    ///     Bash scrip to execute
    /// </summary>
    public required string? Script { get; set; }

    #region Fields are needed only if WaitForOutput = true

    /// <summary>
    ///     Standard output of process
    /// </summary>
    public string? StdOutput { get; set; }

    /// <summary>
    ///     Exit code of process
    /// </summary>
    public int ExitCode { get; set; }

    /// <summary>
    ///     If there is an exception running the program
    /// </summary>
    public string? Exception { get; set; }

    #endregion
}

#endif