namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeAPICallback
{
    /// <summary>
    ///     Id of request to wait for
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    ///     If request fails then go to this bookmark
    /// </summary>
    public string? BookmarkFallback { get; set; }
}
