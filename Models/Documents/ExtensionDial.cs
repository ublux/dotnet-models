// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.ComponentModel.DataAnnotations;

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
    public List<string> IdsPhones { get; set; } = [];

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
    
    /// <summary>
    ///     Only one feature can be turned on
    /// </summary>
    [AllowUpdate(true)]
    public AiExtensionFeatures? AiFeatures { get; set; }

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

/// <summary>
///     Custom AI features
/// </summary>
[UsedImplicitly]
public class AiExtensionFeatures
{
    /// <summary>
    ///     Specific checklist of actions agent is supposed to say
    /// </summary>
    [UsedImplicitly]
    public List<CheckList>? AgentCheckLists { get; set; }
    
    /// <summary>
    ///     Requires transcription in real time
    ///     0 = do not required
    ///     1 = require client
    ///     2 = require agent
    ///     3 = require agent and client (BOTH)
    /// </summary>
    public int RequireTranscriptionInRealTime()
    {
        if (AgentCheckLists is not null)
            return 1;

        // In the future check
        
        return 0;
    }
    
    // Future AI variables...
}

/// <summary>
///     
/// </summary>
[UsedImplicitly]
public class CheckList
{
    /// <summary>
    ///     Title of the checklist
    /// </summary>
    [AllowUpdate(true)]
    public required string Title { get; set; } = string.Empty;

    /// <summary>
    ///     Checklist items that agent or client should say
    /// </summary>
    [AllowUpdate(true)]
    public required List<CheckListItem> Items { get; set; } = [];
}

/// <summary>
///     Checklist item
/// </summary>
[UsedImplicitly]
public class CheckListItem
{
    /// <summary>
    ///     Item
    /// </summary>
    [AllowUpdate(true)]
    [MaxLength(1000)]
    public required string Item { get; set; } = string.Empty;
    
    /// <summary>
    ///     Is the checklist item mentioned in the conversation? 
    /// </summary>
    [AllowUpdate(false)]
    public DateTime? DateComplete { get; set; }

    // /// <summary>
    // ///     Helper method that determines if checklist items is completed
    // /// </summary>
    // public bool IsCompleted() => DateComplete.HasValue;
}