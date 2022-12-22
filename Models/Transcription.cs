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
    public int StartTime { get; set; }

    /// <summary>
    ///     Number of seconds when this text ended being said
    /// </summary>
    public int EndTime { get; set; }

    /// <summary>
    ///     How positive is this text? Percentage between 0 and 1. For example .27 means 27 percent
    /// </summary>
    public double SentimentPositive { get; set; }

    ///// <summary>
    /////     Percent of this text being Neutral
    ///// </summary>
    //public double SentimentNeutral { get; set; }
}
