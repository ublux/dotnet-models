namespace Ublux.Communications.Domain.Models.Documents;

// ReSharper disable ConditionIsAlwaysTrueOrFalse
/// <summary>
///     Basic extension
/// </summary>
public partial class ExtensionDial : Extension
{
    //#region IUbluxDocument

    ///// <inheritdoc/>
    //public override IEnumerable<ValidationError> Validate(IUbluxDatabase? db)
    //{
    //    // check required properties
    //    foreach (var item in this.CheckRequiredPropertiesHaveValue())
    //        yield return item.ToValidationError();
    //}

    //#endregion

    #region Properties

    #region References

    /// <summary>
    ///     Lines to call and ring. Minimum of one line is required
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(true)]
    [IsRequired]
    public List<string> IdsLines
    {
        get => _IdsLines;
        set
        {
            if (value is null) _IdsLines.Clear();
            else _IdsLines = value;
        }
    }

    List<string> _IdsLines = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     EventAction to execute if call is not answered
    /// </summary>
    [AllowUpdate(true)]
    public EventAction? EventActionToExecuteIfCallIsNotAnswered { get; set; }

    /// <summary>
    ///     Send email notification if call is not answered
    /// </summary>
    [AllowUpdate(true)]
    public SendEmailNotificationIfCallIsNotAnswered? SendEmailNotificationIfCallIsNotAnswered { get; set; }

    #endregion

    /// <summary>
    ///     Number of seconds each line will ring
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public int RingTimeInSeconds { get; set; }

    #endregion


    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public override ExtensionType ExtensionType => ExtensionType.Dial;
}