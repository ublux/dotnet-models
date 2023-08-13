namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Basic extension
/// </summary>
public partial class ExtensionDial : Extension
{
    #region Properties

    #region References

    /// <summary>
    ///     Phones to call and ring. Minimum of one line is required
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public List<string> IdsPhones { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     EventAction to execute if call is not answered
    /// </summary>
    [AllowUpdate(true)]
    public EventAction? EventActionToExecuteIfNotAnswered { get; set; }

    /// <summary>
    ///     Send email notification if call is not answered
    /// </summary>
    [AllowUpdate(true)]
    public SendEmailNotificationIfNotAnswered? SendEmailNotificationIfNotAnswered { get; set; }

    /// <summary>
    ///     Handicap to ensure all phones take an equal number of calls
    /// </summary>
    [AllowUpdate(true)]
    public Handicap? Handicap { get; set; }

    #endregion

    /// <summary>
    ///     Number of seconds each line will ring
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required int RingTimeInSeconds { get; set; }

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [HideForCreateRequest]
    public override ExtensionType ExtensionType
    {
        get => ExtensionType.Dial;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}