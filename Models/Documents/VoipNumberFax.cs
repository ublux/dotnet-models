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
    public required override List<RulePhone> RulesPhone { get; set; }

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
    [AllowUpdate(true)]
    public required override List<RuleSms> RulesSms { get; set; }

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required override List<RuleFax> RulesFax { get; set; }

    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public override VoipNumberType VoipNumberType => VoipNumberType.Fax;
}
