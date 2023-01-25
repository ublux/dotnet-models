namespace Ublux.Communications.Enums;

/// <summary>
///     Simple notification service topic. Example call_completed.
/// </summary>
public enum SnsTopic
{
    /// <summary>
    ///     Item Created
    /// </summary>
    Collection_Created,

    /// <summary>
    ///     Item updated
    /// </summary>
    Collection_Updated,

    /// <summary>
    ///     Item deleted
    /// </summary>
    Collection_Deleted,

    /// <summary>
    ///     If a call terminates
    /// </summary>
    Call_Terminated,

    /// <summary>
    ///     When a line is disconnected
    /// </summary>
    Line_Disconnected,

    /// <summary>
    ///     When a line is connected
    /// </summary>
    Line_Connected
}
