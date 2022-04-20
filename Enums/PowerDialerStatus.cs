namespace Ublux.Communications.Domain.Enums;

/// <summary>
///     Status of power dialer
/// </summary>
public enum PowerDialerStatus
{
    /// <summary>
    ///     This means powerdialer group has not started. Once the whole group starts all child calls should change status to pending
    /// </summary>
    ToBeStarted = 0,

    /// <summary>
    ///     This means powerdialer group has started but this call has not started
    /// </summary>
    Pending = 1,

    /// <summary>
    ///     Call is in progress
    /// </summary>
    InProgress = 2,

    /// <summary>
    ///     Power dialer failed 
    /// </summary>
    Failed = 3,

    /// <summary>
    ///     This happens if powerdialer continues to execute until there is a timeout
    /// </summary>
    ExceededDateLimit = 4,

    /// <summary>
    ///     Completed
    /// </summary>
    Completed = 5,

    /// <summary>
    ///     Canceled
    /// </summary>
    Canceled = 6,

    /// <summary>
    ///     Attempts up to 3 times
    /// </summary>
    Retrying = 7,

    /// <summary>
    ///     If paused
    /// </summary>
    Paused = 8,
}
