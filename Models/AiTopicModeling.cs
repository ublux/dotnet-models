namespace Ublux.Communications.Models;

/// <summary>
///     Used by AI on calls
/// </summary>
public class AiTopicModeling
{
    /// <summary> Topic Name </summary>
    public string? Name { get; set; }

    /// <summary> Phrases related </summary>
    public List<string> RelatedPhrases { get; set; } = new();

    /// <summary> Weight </summary>
    public List<double> Weight { get; set; } = new();
}
