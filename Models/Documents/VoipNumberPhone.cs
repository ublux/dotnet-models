namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone number configured to receive phone calls
/// </summary>
public partial class VoipNumberPhone : VoipNumber
{
    /// <summary>
    ///     key = id of logic OR id of extension.  
    ///     value = day of week when it executes
    /// </summary>    
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public override required List<RulePhone> RulesPhone { get; set; } = [];

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
    [AllowUpdate(true)]
    public override required List<RuleSms> RulesSms { get; set; } = [];

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
    [AllowUpdate(true)]
    public override required List<RuleFax> RulesFax { get; set; } = [];

    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public override VoipNumberType VoipNumberType
    {
        get => VoipNumberType.Phone;
#if UBLUX_Release || RELEASE
        set { }
#endif
    }

    /// <summary>
    ///     If there are 3 consecutive missed calls for a specific phone number then maybe that number is not working and we want to send an email.
    /// </summary>
    [AllowUpdate(true)]
    public RuleConsecutiveMissedCalls? RuleConsecutiveMissedCalls { get; set; }
}