namespace Ublux.Communications.Models;

/// <summary>
///     Sentiment of phrase or conversation
/// </summary>
public class AiSentiment
{
    /// <summary>
    ///     Positive sentiment. This is a value between 0 and 100 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int Positive { get; set; } = 0;

    /// <summary>
    ///     Negative sentiment. This is a value between 0 and 100 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int Negative { get; set; } = 0;

    /// <summary>
    ///     Neutral sentiment. This is a value between 0 and 100 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int Neutral { get; set; } = 0;
}

