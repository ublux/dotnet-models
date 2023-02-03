namespace Ublux.Communications.Models;

/// <summary>
///     AI Summary of sentiment analysis
/// </summary>
public class AiSentimentAnalysisSummary
{
    /// <summary>
    ///     Total number of phrases
    /// </summary>
    public int TotalNumberPhrases { get; set; }

    /// <summary>
    ///     Positive rating
    /// </summary>
    public double PositiveRate { get; set; }

    /// <summary>
    ///     Negative rating
    /// </summary>
    public double NegativeRate { get; set; }

    /// <summary>
    ///     Average positive probability
    /// </summary>
    public double AvgPositiveProb { get; set; }

    /// <summary>
    ///     Average negative probability
    /// </summary>
    public double AvgNegativeProb { get; set; }
}