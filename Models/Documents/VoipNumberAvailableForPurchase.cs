namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Incoming phone number available for purchase
/// </summary>
public partial class VoipNumberAvailableForPurchase : VoipNumber
{
    

    #region Properties

    /// <summary>
    ///     key = id of logic OR id of extension.  
    ///     value = day of week when it executes
    /// </summary>    
        [AllowUpdate(false)]
    public override List<RulePhone> RulesPhone
    {
        get => _RulesVoice;
        set { if (value is null) _RulesVoice.Clear(); else _RulesVoice = value; }
    }
    List<RulePhone> _RulesVoice = new();

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
        [AllowUpdate(false)]
    public override List<RuleSms> RulesSms
    {
        get => _RulesSms;
        set { if (value is null) _RulesSms.Clear(); else _RulesSms = value; }
    }
    List<RuleSms> _RulesSms = new();

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
        [AllowUpdate(false)]
    public override List<RuleFax> RulesFax
    {
        get => _RulesFax;
        set { if (value is null) _RulesFax.Clear(); else _RulesFax = value; }
    }
    List<RuleFax> _RulesFax = new();

    /// <summary>
    ///     Requires customer info in order to be purchased
    /// </summary>
        [AllowUpdate(false)]
    public bool RequiresCustomerInfo { get; set; }

    /// <summary>
    ///     Phone numbers from AirNetwoks for example must be configured on their portal for them to work
    /// </summary>
        [AllowUpdate(false)]
    public bool PendingToBeConfigured { get; set; }

    #endregion


    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public override VoipNumberType VoipNumberType => VoipNumberType.AvailableForPurchase;
}
