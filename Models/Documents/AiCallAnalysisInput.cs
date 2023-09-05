namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Determines how will a call be AI processed. What questions will be asked to the AI engine
/// </summary>
[BsonIgnoreExtraElements]
public partial class AiCallAnalysisInput : UbluxDocument_ReferenceAccount_ReferenceTags
{
    /// <summary>
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = "";

    /// <summary>
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(0, 2000)]
    public string? Description { get; set; } = "";

    /// <summary>
    ///     List of queries to ask AI engine about a call
    /// </summary>    
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public List<AiCallAnalysisQuery> Queries { get; set; } = new();

    /// <summary>
    ///     Send email
    /// </summary>
    [AllowUpdate(true)]
    public AiCallSendEmail? SendEmail { get; set; }

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }

    /// <summary>
    ///     Engine to use. If null Ublux will use the default engine
    /// </summary>
    [AllowUpdate(true)]
    public string? Engine { get; set; }
}

/// <summary>
///     Send email?
/// </summary>
public class AiCallSendEmail
{
    /// <summary>
    ///     Emails to send if any of the questions asked contains a specific keyword on Variable IfResponseContainsKeywordSendEmail
    /// </summary>
    [AllowUpdate(true)]
    public List<string> Emails { get; set; } = new();

    /// <summary>
    ///     For example we may want to send emails to different managers depending phone number that is being called
    /// </summary>
    [AllowUpdate(true)]
    public List<EmailsRules> EmailsRules { get; set; } = new();

    /// <summary>
    ///     If sending an email what will be the subject of the email?
    /// </summary>
    [AllowUpdate(true)]
    public string? EmailSubject { get; set; }

    /// <summary>
    ///     Verify with ublux support before sending alert email
    /// </summary>
    [AllowUpdate(true)]
    public bool EmailRequiresUbluxSupportConfirmation { get; set; }
}

/// <summary>
///     Send additional emails depending phone number
/// </summary>
public class EmailsRules
{
    /// <summary>
    ///     If phone contains this send email to this additional emails. Also if friendly name did contains
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public string PhoneNumber { get; set; } = "";

    /// <summary>
    ///     Emails to send if any of the questions asked contains a specific keyword on Variable IfResponseContainsKeywordSendEmail
    /// </summary>
    // [References(typeof(Email))]
    public List<string> Emails { get; set; } = new();
}
