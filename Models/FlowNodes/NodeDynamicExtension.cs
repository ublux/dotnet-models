namespace Ublux.Communications.Models.FlowNodes;

/// <summary></summary>
public partial class NodeDynamicExtension
{
    /// <summary>
    ///     If extension is not found then call this extension
    /// </summary>
    public string? IdExtensionDefault { get; set; }

    /// <summary>
    ///     Prevent calling this extensions
    /// </summary>
    public List<string> IdsExtensionsToExclude { get; set; } = new List<string>();
}
