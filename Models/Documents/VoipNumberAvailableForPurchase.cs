namespace Ublux.Communications.Models.Documents;

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
    [SwaggerSchema(ReadOnly = true)] 
    public override List<RulePhone> RulesPhone { get; set; } = new();

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public override List<RuleSms> RulesSms { get; set; } = new();

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public override List<RuleFax> RulesFax { get; set; } = new();

    /// <summary>
    ///     Requires customer info in order to be purchased
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public bool RequiresCustomerInfo {
        get { try { /*custom-get-code*/ _lock.EnterReadLock(); return _RequiresCustomerInfo; } finally { _lock.ExitReadLock(); } }
        set { try { _lock.EnterWriteLock(); _RequiresCustomerInfo = value; /*custom-set-code*/ } finally { _lock.ExitWriteLock(); }}
    }
    private bool _RequiresCustomerInfo;

    /// <summary>
    ///     Phone numbers from AirNetwoks for example must be configured on their portal for them to work
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public bool PendingToBeConfigured {
        get { try { /*custom-get-code*/ _lock.EnterReadLock(); return _PendingToBeConfigured; } finally { _lock.ExitReadLock(); } }
        set { try { _lock.EnterWriteLock(); _PendingToBeConfigured = value; /*custom-set-code*/ } finally { _lock.ExitWriteLock(); }}
    }
    private bool _PendingToBeConfigured;

    #endregion

    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public override VoipNumberType VoipNumberType
    {
        get => VoipNumberType.AvailableForPurchase;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
