namespace Ublux.Communications.Domain.Enums;

/// <summary>
///     Status of power dialer group
/// </summary>
public enum PowerDialerGroupStatus
{
    /// <summary></summary>
    ToBeStarted = 0,
    /// <summary></summary>
    Started = 1,
    /// <summary></summary>
    Paused = 2,
    /// <summary></summary>
    Canceled = 3,
    /// <summary></summary>
    Failed = 4,
    /// <summary></summary>
    Completed = 5
}
