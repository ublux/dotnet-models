namespace Ublux.Communications.Models;

#warning todo

public class AiAnalysis
{
    public required AiSentiment Sentiment { get; set; }

    public required List<AiEntity> Entities { get; set; } = new();

    /// <summary>
    ///     Example: noise, hotel room, customer service
    /// </summary>
    public required List<string> Topics { get; set; } = new();

    /// <summary>
    ///     Intentions
    /// </summary>
    public required List<AiIntention> Intentions { get; set; } = new();
}

/// <summary>
///     Sentiment of phrase or conversation
/// </summary>
public class AiSentiment
{
    /// <summary>
    ///     Positive, Neutral or Negative
    /// </summary>
    public required string Label { get; set; }

    /// <summary>
    ///     Confidence of sentiment
    /// </summary>
    public double Confidence { get; set; }
}

/// <summary>
///     AI Entity. Example a hotel of type location
/// </summary>
public class AiEntity
{
    /// <summary>
    ///     Example: hotel
    /// </summary>
    public required string Entity { get; set; }

    /// <summary>
    ///     Example: location
    /// </summary>
    public required string Type { get; set; }
}

/// <summary>
///     AI Intention
/// </summary>
public class AiIntention
{
    /// <summary>
    ///     Example: Complaint
    /// </summary>
    public required string Intent { get; set; }

    /// <summary>
    ///     Confidence of intent
    /// </summary>
    public double Confidence { get; set; }
}