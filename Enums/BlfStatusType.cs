namespace Ublux.Communications.Enums;

/// <summary>
///     Outgoing is the channel that makes the call
///     Incoming is the channel receiveing the call
/// </summary>
public enum BlfStatusType
{    
    /// <summary>
    ///     No status
    /// </summary>
    None,

    /// <summary>
    ///     Line is calling/ringing another party
    /// </summary>
    Outgoing_Ringing,

    /// <summary>
    ///     Line is calling another party
    /// </summary>
    Outgoing_InProgress,

    /// <summary>
    ///     Line call someone and was placed on hold
    /// </summary>
    Outgiong_OnHold,



    /// <summary>
    ///     Line is ringing because its receiving a new phone call
    /// </summary>
    Incoming_Ringing,

    /// <summary>
    ///     When call is answered it is now in progress
    /// </summary>
    Incoming_InProgress,

    /// <summary>
    ///     Line answered a call and placed that call on hold
    /// </summary>
    Incoming_OnHold,
}
