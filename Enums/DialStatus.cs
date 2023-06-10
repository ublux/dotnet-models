namespace Ublux.Communications.Enums;

/// <summary>
///     Type of call. https://wiki.asterisk.org/wiki/display/AST/Asterisk+18+Application_Dial
/// </summary>
public enum DialStatus
{
    /// <summary>
    ///     No status
    /// </summary>
    None,

    ///// <summary>
    /////     Either the dialed peer exists but is not currently reachable, e.g. endpoint is not registered, or an attempt was made to call a nonexistent location, e.g. nonexistent DNS hostname.
    ///// </summary>
    //CHANUNAVAIL,

    ///// <summary>
    /////      Channel or switching congestion occured when routing the call. This can occur if there is a slow or no response from the remote end.
    ///// </summary>
    //CONGESTION,

    /// <summary>
    ///     This is part of ublux and not asterisk
    /// </summary>
    RINGING,

    /// <summary>
    ///     Called party did not answer.
    /// </summary>
    NOANSWER,

    /// <summary>
    ///     The person that received call hangup
    /// </summary>
    HANGUP,

    /// <summary>
    ///     Person that made call hangup
    /// </summary>
    CANCEL,

    /// <summary>
    ///     The called party was busy or indicated a busy status. Note that some SIP devices will respond with 486 Busy if their Do Not Disturb modes are active. In this case, you can use DEVICE_STATUS to check if the endpoint is actually in use, if needed.
    /// </summary>
    BUSY,

    /// <summary>
    ///     When a call is made to an IVR it is autoanswered. We created this status for those cases.
    /// </summary>
    CALLFLOW,

    /// <summary>
    ///     The call was answered. Any other result implicitly indicates the call was not answered.
    /// </summary>
    ANSWER,

    /// <summary>
    ///     If calling lines are ofline for example
    /// </summary>
    UNAVAILABLE,

    ///// <summary>
    /////      For the Privacy and Screening Modes. Will be set if the called party chooses to send the calling party to the 'Go Away' script.
    ///// </summary>
    //DONTCALL,

    ///// <summary>
    /////     For the Privacy and Screening Modes. Will be set if the called party chooses to send the calling party to the 'torture' script.
    ///// </summary>
    //TORTURE,

    ///// <summary>
    /////      Dial failed due to invalid syntax.
    ///// </summary>
    //INVALIDARGS,

    /// <summary>
    ///     Some error ocured
    /// </summary>
    ERROR,
}
