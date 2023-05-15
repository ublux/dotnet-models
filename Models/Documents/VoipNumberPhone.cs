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
    public required override List<RulePhone> RulesPhone { get; set; } = new();

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
    [AllowUpdate(true)]
    public required override List<RuleSms> RulesSms { get; set; } = new();

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
    [AllowUpdate(true)]
    public required override List<RuleFax> RulesFax { get; set; } = new();

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
}
