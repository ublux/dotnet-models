namespace Ublux.Communications.Models;

/// <summary>
///     AI call analysis variable query sent to AI engine
/// </summary>p
public class AiCallAnalysisQuery : AiCallAnalysisVariable
{
    /// <summary>
    ///     Question to ask AI engine about conversation. For example: Client satisfaction with integer value ranging from 1 to 5
    /// </summary>
    [UbluxValidationStringRange(0, 5_000)]
    public required string Query { get; set; }

    /// <summary>
    ///     Interface because swagger will have an infinite loop if not 
    /// </summary>
    [AllowUpdate(true)]
    public AiCallAnalysisSubQuery? SubQueries { get;set; }

    /// <summary>
    ///     If response contains any of this keywords send email
    /// </summary>
    public List<string> IfResponseContainsKeywordSendEmail { get; set; } = [];
}

/// <summary>
///     If response contains any of this keywords ask more questions to AI engine
/// </summary>
public class AiCallAnalysisSubQuery 
{
    /// <summary>
    ///     If response contains keyword then query AI engine again
    /// </summary>
    public List<string> IfResponseContainsKeywordQueryEngine { get; set; } = [];

    /// <summary>
    ///     Secondary input query to ask AI engine in case response contains keyword.
    ///     For example if the question is to find out if there is a problem we can have a second question to see what type of problem and how severe.
    /// </summary>
    [AllowUpdate(true)]
    public List<AiCallAnalysisQuery> Queries { get; set; } = [];

    /// <summary>
    ///     Engine to use. If null Ublux will use the default engine
    /// </summary>
    [AllowUpdate(true)]
    public string? Engine { get; set; }
}
