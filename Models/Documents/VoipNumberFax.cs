namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone number configured to receive faxes
/// </summary>
public partial class VoipNumberFax : VoipNumber
{
    /// <summary>
    ///     key = id of logic OR id of extension.  
    ///     value = day of week when it executes
    /// </summary>    
    [AllowUpdate(true)]
    public override required List<RulePhone> RulesPhone { get; set; } = new();

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
    [AllowUpdate(true)]
    public override required List<RuleSms> RulesSms { get; set; } = new();

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public override required List<RuleFax> RulesFax { get; set; } = new();

    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public override VoipNumberType VoipNumberType
    {
        get => VoipNumberType.Fax;

#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
