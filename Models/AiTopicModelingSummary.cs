namespace Ublux.Communications.Models;

/// <summary>
///     AI Topic modeling summary
/// </summary>
public class AiTopicModelingSummary
{
    /// <summary>
    ///     Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     Related phrases
    /// </summary>
    public List<string> RelatedPhrases { get; set;} = new ();

    /// <summary>
    ///     Weight
    /// </summary>
    public List<double> Weight { get; set;} = new ();
}
