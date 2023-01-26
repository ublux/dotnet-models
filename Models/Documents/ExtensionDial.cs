﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Basic extension
/// </summary>
public partial class ExtensionDial : Extension
{
    #region Properties

    #region References

    /// <summary>
    ///     Lines to call and ring. Minimum of one line is required
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public List<string> IdsLines { get; set; } = new();

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

    #endregion

    /// <summary>
    ///     Number of seconds each line will ring
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required int RingTimeInSeconds { get; set; }

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public override ExtensionType ExtensionType
    {
        get => ExtensionType.Dial;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}