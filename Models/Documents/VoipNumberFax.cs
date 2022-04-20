namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
    public override List<RulePhone> RulesPhone
    {
        get => _RulesVoice;
        set { if (value is null) _RulesVoice.Clear(); else _RulesVoice = value; }
    }
    List<RulePhone> _RulesVoice = new();

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
        [AllowUpdate(true)]
    public override List<RuleSms> RulesSms
    {
        get => _RulesSms;
        set { if (value is null) _RulesSms.Clear(); else _RulesSms = value; }
    }
    List<RuleSms> _RulesSms = new();

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
        [AllowUpdate(true)]
    [IsRequired]
    public override List<RuleFax> RulesFax
    {
        get => _RulesFax;
        set { if (value is null) _RulesFax.Clear(); else _RulesFax = value; }
    }
    List<RuleFax> _RulesFax = new();


    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public override VoipNumberType VoipNumberType => VoipNumberType.Fax;
}
