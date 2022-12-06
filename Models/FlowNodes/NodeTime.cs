namespace Ublux.Communications.Models.FlowNodes;

/// <summary></summary>
public partial class NodeTime
{
    /// <summary>
    ///     Start time in 24 hour format. Example 14:00
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    ///     Start time in 24 hour format. Example 16:30
    /// </summary>
    public required string EndTime { get; set; }
}
