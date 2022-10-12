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
    [IsUbluxRequired]
    public required override List<RuleFax> RulesFax { get; set; }

    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override VoipNumberType VoipNumberType
    {
        get => VoipNumberType.Fax;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}
