namespace Ublux.Communications.Models;

/// <summary>
///     AI analysis of conversation in a phone call
/// </summary>
[Obsolete("we do not hardcode stuff anymore")]
public class AiCallAnalysis
{
    /// <summary>
    ///     Sentiment of phone call in percentages
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiSentiment? Sentiment { get; set; }

    /// <summary>
    ///     Entities mentioned in the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiEntity> Entities { get; set; } = new();

    /// <summary>
    ///     Topics mentioned in the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiTopic> Topics { get; set; } = new();

    /// <summary>
    ///     Intention of client summarized
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(2000)]
    public string? ClientIntention { get; set; }

    /// <summary>
    ///     Intention of agent summarized
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(2000)]
    public string? AgentIntention { get; set; }

    /// <summary>
    ///     Summary of conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(4000)]
    public string? Summary { get; set; }

    /// <summary>
    ///     Problem of the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(2000)]
    public string? Problem { get; set; }

    /// <summary>
    ///     Was client polite? This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? ClientPolite { get; set; }

    /// <summary>
    ///     Was agent polite? This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? AgentPolite { get; set; }

    /// <summary>
    ///     Client satisfaction from 1 to 5.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int ClientSatisfaction { get; set; }

    /// <summary>
    ///     Detected language
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string Language { get; set; } = "";

    /// <summary>
    ///     Example: gpt-3.5-turbo
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? Model { get; set; }

    ///// <summary>
    /////     If there is an error message analysing the call
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public string? ErrorMessage { get; set; }

    /// <summary>
    ///     Based on the conversation, what action should the agent take next?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(2000)]
    public string? ActionAgentShouldTakeNext { get; set; }

    /// <summary>
    ///     Measure the interest that the client has expressed in the product ranging from 1 to 5. 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int? ClientInterestInProduct { get; set; }
}

