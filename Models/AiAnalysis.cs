namespace Ublux.Communications.Models;


/// <summary>
///     AI analysis of conversation in a phone call
/// </summary>
public class AiAnalysis
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

/// <summary>
///     Sentiment of phrase or conversation
/// </summary>
public class AiSentiment
{
    /// <summary>
    ///     Positive sentiment. This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int Positive { get; set; } = 0;

    /// <summary>
    ///     Negative sentiment. This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int Negative { get; set; } = 0;

    /// <summary>
    ///     Neutral sentiment. This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int Neutral { get; set; } = 0;
}

/// <summary>
///     AI Entity. Example: Date with value January 1, 2023
/// </summary>
public class AiEntity
{
    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string EntityType { get; set; } = "";

    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string EntityName { get; set; } = "";
}

/// <summary>
///     AI Topic. Example: Noise with weight .8
/// </summary>
public class AiTopic
{
    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string Name { get; set; } = "";

    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double Weight { get; set; } 
}

