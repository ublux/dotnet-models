namespace Ublux.Communications.Models;

/// <summary>
///     Converted audio to text
/// </summary>
public partial class Transcription
{
    /// <summary>
    ///     Transcription text
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string Text { get; set; } = "";

    /// <summary>
    ///     Number of seconds when this text was said
    /// </summary>
    public double StartTime { get; set; }

    /// <summary>
    ///     Number of seconds when this text ended being said
    /// </summary>
    public double EndTime { get; set; }

    /// <summary>
    ///     How positive is this text? Percentage between 0 and 1. For example .27 means 27 percent
    /// </summary>
    public double SentimentPositive { get; set; }

    /// <summary>
    ///     Percent of this text being Neutral
    /// </summary>
    public double SentimentNeutral { get; set; }

    /// <summary>
    ///     Percent of this text being Negative
    /// </summary>
    public double SentimentNegative { get; set; }

    /// <summary>
    ///     True =  Positive
    ///     null =  Neutral
    ///     False = Negative
    /// </summary>
    public bool? IsPositive { get; set; }

    /// <summary>
    ///     Detected entities. For example if in the phrase
    /// </summary>
    public List<EntityDetection> Entities { get; set; } = new();

    /// <summary>
    ///     Examples: Football, tennis
    /// </summary>
    public List<TopicModeling> Topics { get; set; } = new();
}

public class EntityDetection
{
    public int StartPosition { get; set; }
    public int EndPosition { get; set; }
    public EntityType EntityType { get; set; }
    public string? EntityName { get; set; }
}

public enum EntityType
{
    Unknown,
    Person
}

public class TopicModeling
{
    public string? Name { get; set; }
    public List<string> RelatedPhrases { get; set; } = new();
    public List<double> Weight { get; set; } = new();
}


