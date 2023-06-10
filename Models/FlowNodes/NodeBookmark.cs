namespace Ublux.Communications.Models.FlowNodes;

/// <summary></summary>
public partial class NodeBookmark
{
    /// <summary>
    ///     Name of bookmark
    /// </summary>
    [UbluxValidationRequired]
    public required string Name { get; set; }
}
