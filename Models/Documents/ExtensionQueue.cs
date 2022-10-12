namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Extension where people that call will be placed on a sequence awaiting their turn to be attended
/// </summary>
public partial class ExtensionQueue : Extension
{
    #region Properties

    #region References

    /// <summary>
    ///     Lines to ring
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public List<string> IdsLines { get; set; } = new();

    /// <summary>
    ///     If there is a timeout to what extension we will forward the call?
    /// </summary>
    [References(typeof(Extension))]
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string IdExtensionIfTimeout { get; set; }

    /// <summary>
    ///     Audios to play meanwhile caller is waiting to be attended
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    public List<string> IdsAudios { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Send email notification if call is not answered
    /// </summary>
    [AllowUpdate(true)]
    public SendEmailNotificationIfCallIsNotAnswered? SendEmailNotificationIfCallIsNotAnswered { get; set; }

    /// <summary>
    ///     Send email notification if call takes to long to be answered
    /// </summary>
    [AllowUpdate(true)]
    public SendEmailNotificationIfCallTakesToLongToBeAnswered? SendEmailNotificationIfCallTakesToLongToBeAnswered
    {
        get;
        set;
    }

    #endregion

    /// <summary>
    ///     Time that lines will ring in seconds until answered
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required int RingTimeInSeconds { get; set; }

    /// <summary>
    ///     If line is busy do you still want it to ring it?
    /// </summary>
    [AllowUpdate(true)]
    public bool RingInUse { get; set; }

    /// <summary>
    ///     Maximum amount of minutes a user can be waiting on the queue.
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required int QueueTimeoutInMinutes { get; set; }

    /// <summary>
    ///     Play position announcements. For example say things like you are now position 2 in queue. There are 2 calls ahead of you.
    /// </summary>
    [AllowUpdate(true)]
    public bool PlayPositionAnnouncements { get; set; }

    /// <summary>
    ///     Number of seconds to wait in between rings. Default value if null is 20 seconds
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required int RetryFrequency { get; set; }

    /// <summary>
    ///     Strategy to ring queue. Default is RingAll
    /// </summary>
    [AllowUpdate(true)]
    public QueueRingStrategy RingStrategy { get; set; }

    #endregion

    #region Helper methods



    /// <summary>
    ///     Timeout in seconds.
    /// </summary>
    public int GetQueueTimeoutInSeconds() => QueueTimeoutInMinutes * 60;

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override ExtensionType ExtensionType
    {
        get => ExtensionType.Queue;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}