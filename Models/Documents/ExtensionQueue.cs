namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Extension where people that call will be placed on a sequence awaiting their turn to be attended
/// </summary>
public partial class ExtensionQueue : ExtensionDial
{
    #region Properties

    #region References

    /// <summary>
    ///     Audios to play meanwhile caller is waiting to be attended
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    public List<string> IdsAudios { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Send email notification if call takes to long to be answered
    /// </summary>
    [AllowUpdate(true)]
    public SendEmailNotificationIfItTakesToLongToBeAnswered? SendEmailNotificationIfItTakesToLongToBeAnswered
    {
        get;
        set;
    }

    #endregion

    /// <summary>
    ///     If line is busy do you still want it to ring it?
    /// </summary>
    [AllowUpdate(true)]
    public bool RingInUse { get; set; }

    /// <summary>
    ///     Maximum amount of minutes a user can be waiting on the queue.
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required int QueueTimeoutInMinutes { get; set; }

    /// <summary>
    ///     Play position announcements. For example say things like you are now position 2 in queue. There are 2 calls ahead of you.
    /// </summary>
    [AllowUpdate(true)]
    public bool AnnouncePosition { get; set; }

    /// <summary>
    ///     Play thinks like. Currently wait time is 2 minutes
    /// </summary>
    [AllowUpdate(true)]
    public bool AnnounceHoldTime { get; set; }

    /// <summary>
    ///    How often to announce stuff?
    /// </summary>
    [AllowUpdate(true)]
    public int AnnounceFrequency { get; set; }

    /// <summary>
    ///     Number of seconds to wait in between rings. Default value if null is 20 seconds
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required int RetryFrequency { get; set; }

    /// <summary>
    ///     Strategy to ring queue. Default is RingAll
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
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
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public override ExtensionType ExtensionType
    {
        get => ExtensionType.Queue;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}