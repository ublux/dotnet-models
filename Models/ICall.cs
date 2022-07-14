namespace Ublux.Communications.Models;

/// <summary>
///     Child calls and parent calls must contain this
/// </summary>
public partial interface ICall
{
    /// <summary>
    ///     Date when call was created
    /// </summary>
    [AllowUpdate(false)]
    DateTime DateCreated { get; set; }

    /// <summary>
    ///     DateEnded - DateCreated will let you know the duration of call
    /// </summary>
    [AllowUpdate(false)]
    DateTime? DateEnded { get; set; }

    /// <summary>
    ///     ANSWER: Call is answered. A successful dial. The caller reached the callee.
    ///     BUSY: Busy signal. The dial command reached its number but the number is busy.
    ///     NOANSWER: No answer. The dial command reached its number, the number rang for too long, then the dial timed out.
    ///     CANCEL: Call is canceled. The dial command reached its number but the caller hung up before the callee picked up.
    ///     CONGESTION: Congestion. This status is usually a sign that the dialed number is not recognized.
    ///     CHANUNAVAIL: Channel unavailable. On SIP, peer may not be registered.
    ///     DONTCALL: Privacy mode, callee rejected the call
    ///     TORTURE: Privacy mode, callee chose to send caller to torture menu
    ///     INVALIDARGS: Error parsing Dial command arguments (added for Asterisk 1.4.1, SVN r53135-53136)
    /// </summary>
    [AllowUpdate(false)]
    string DialStatus { get; set; }
}

