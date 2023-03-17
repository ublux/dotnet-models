namespace Ublux.Communications.Models;


/*
{
  "sentiment": {
    "positive": 0,
    "negative": 0.7,
    "neutral": 0.3
  },
  "entities": [
    "ruidos",
    "televisión",
    "vecinos",
    "hijos"
  ],
  "topics": [
    "ruidos",
    "vecinos",
    "discusión",
    "problema"
  ],
  "clientIntention": "reportar problema",
  "agentIntention": "resolver problema",
  "summary": "El cliente reporta ruidos insoportables provenientes de los vecinos y el agente no atiende su problema adecuadamente.",
  "problem": "Ruidos insoportables de los vecinos que perturban el sueño de los hijos del cliente.",
  "clientPolite": 0.7,
  "agentPolite": 0.1
}
 */

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
    public List<string>? Entities { get; set; }

    /// <summary>
    ///     Topics mentioned in the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string>? Topics { get; set; }

    /// <summary>
    ///     Intention of client summarized
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ClientIntention { get; set; }

    /// <summary>
    ///     Intention of agent summarized
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? AgentIntention { get; set; }

    /// <summary>
    ///     Summary of conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? Summary { get; set; }

    /// <summary>
    ///     Problem of the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
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
    public double Positive { get; set; } = 0;

    /// <summary>
    ///     Negative sentiment. This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double Negative { get; set; } = 0;

    /// <summary>
    ///     Neutral sentiment. This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double Neutral { get; set; } = 0;
}
