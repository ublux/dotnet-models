namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeKeyword
{
    /// <summary>
    ///     If it contains this keywords
    /// </summary>
    public List<string> Keywords { get; set; } = new();

    /// <summary>
    ///      User can also press this digit instead of saying the keyword
    /// </summary>
    public string? Digit { get; set; }
}

