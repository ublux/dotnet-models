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

    /// <summary>
    ///     When a call transcription is complete
    /// </summary>
    Transcription_Complete,

    /// <summary>
    ///     When a call ai analysis is complete
    /// </summary>
    AiAnalysis_Complete,

    #endregion

    #region PBX
    
    /// <summary>
    ///     If there is a new call
    /// </summary>
    Call_Started,

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
    Extension_Unanswered,

#warning TODO
    /// <summary>
    ///     Extension answered
    /// </summary>
    Extension_Answered,

    /// <summary>
    ///     If extension takes too long to be answered
    /// </summary>
    Extension_TookToLongToBeAnswered,

    /// <summary>
    ///     If call is placed on hold for too long
    /// </summary>
    Call_PlacedOnHoldForTooLong,

    //SMS_Received,
    //SMS_Sent,

#warning TODO
    Fax_Received,
    Fax_Sent,
    
    Fax_ReceivedFailed,
    Fax_SentFailed,

    Fax_ReceivingProgress,
    Fax_SendingProgress,

    // Data: IdCallFlowLogic
    // Tag: Path 1,2,1,1,label:start,1,1,1
    CallFlowLogic_Progress,

    #endregion

    /// <summary>
    ///     IdLine, BlfStatus[]
    /// </summary>
    BLF,
}
