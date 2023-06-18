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
    ///     Call terminates with recording. Takes longer than call terminated because recording has to be uploaded
    /// </summary>
    Call_TerminatedWithRecording,

    /// <summary>
    ///     When a line is disconnected (enqueues)
    /// </summary>
    Phone_Disconnected,

    /// <summary>
    ///     When a line is connected. (enqueues)
    /// </summary>
    Phone_Connected,

    /// <summary>
    ///     If an extension is not answered
    /// </summary>
    Extension_Unanswered,

#warning TODO implement missing webhooks
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

#warning TODO implement missing sns topics

    /// <summary>
    ///     Fax is received
    /// </summary>
    Fax_Received,

    /// <summary>
    ///     Fax is sent
    /// </summary>
    Fax_Sent,
    
    /// <summary>
    ///     Fax received failed
    /// </summary>
    Fax_ReceivedFailed,

    /// <summary>
    ///     Fax sent failed
    /// </summary>
    Fax_SentFailed,

    /// <summary>
    ///     Fax receiving progress changed
    /// </summary>
    Fax_ReceivingProgress,

    /// <summary>
    ///     Fax sending progress changed
    /// </summary>
    Fax_SendingProgress,

    /// <summary>
    ///     Fall flow logic progress changed to a new node
    ///         Data: IdCallFlowLogic
    ///         Tag: Path 1,2,1,1,label:start,1,1,1
    /// </summary>
    CallFlowLogic_Progress,

    #endregion

    /// <summary>
    ///     IdPhone, BlfStatus[]
    /// </summary>
    BLF,
}
