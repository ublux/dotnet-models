namespace Ublux.Communications.Enums;

/// <summary>
///     Status of power dialer
/// </summary>
public enum PowerDialerStatus
{
    /// <summary>
    ///     No status
    /// </summary>
    None,

    /// <summary>
    ///     This means powerdialer group has started but this call has not started
    /// </summary>
    Pending,

    /// <summary>
    ///     When client requests PowerDialerContact to ensure to agents do not call the same contact.
    /// </summary>
    AssignedToAgent,

    /// <summary>
    ///     Call is in progress
    /// </summary>
    Started,

    /// <summary>
    ///     Power dialer failed 
    /// </summary>
    Failed,

    ///// <summary>
    /////     This happens if powerdialer continues to execute until there is a timeout
    ///// </summary>
    //ExceededDateLimit,

    /// <summary>
    ///     Completed
    /// </summary>
    Completed,

    ///// <summary>
    /////     Canceled
    ///// </summary>
    //Canceled,
 
}
