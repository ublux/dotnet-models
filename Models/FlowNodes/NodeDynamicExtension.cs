namespace Ublux.Communications.Models.FlowNodes;

/// <summary></summary>
public partial class NodeDynamicExtension
{
    ///// <summary>
    /////     If extension is not found then goto this bookmark
    ///// </summary>
    //public string? IdExtensionDefault { get; set; }

    /// <summary>
    ///     If extension is not found then goto this bookmark
    /// </summary>
    public string? Bookmark { get; set; }

    /// <summary>
    ///     Prevent calling this extensions
    /// </summary>
    public List<string> IdsExtensionsToExclude { get; set; } = new List<string>();
}
