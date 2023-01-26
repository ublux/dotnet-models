namespace Ublux.Communications.Enums;

/// <summary>
///     Simple notification service topic. Example call_completed.
/// </summary>
public enum SnsTopic
{
    #region WS

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

    #endregion

    #region PBX

    /// <summary>
    ///     If a call terminates (enqueues)
    /// </summary>
    Call_Terminated,

    /// <summary>
    ///     When a line is disconnected (enqueues)
    /// </summary>
    Line_Disconnected,

    /// <summary>
    ///     When a line is connected. (enqueues)
    /// </summary>
    Line_Connected,

    /// <summary>
    ///     If an extension is not answered
    /// </summary>
    Extension_Unanswered




    #endregion
}
