namespace Ublux.Communications.Enums;

/// <summary>
///     Status of power dialer group
/// </summary>
public enum PowerDialerGroupStatus
{
    /// <summary> No status </summary>
    None,
    /// <summary>PowerDialerGroup has been created and is pending to be started </summary>
    Pending,
    /// <summary>PowerDialerGroup is started and running </summary>
    Started,
    /// <summary>PowerDialerGroup is paused </summary>
    Paused,
    /// <summary>PowerDialerGroup is canceled </summary>
    Canceled,
    /// <summary>PowerDialerGroup has failed </summary>
    Failed,
    /// <summary>PowerDialerGroup is completed </summary>
    Completed,
}
