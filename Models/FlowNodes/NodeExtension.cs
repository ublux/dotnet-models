namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeExtension
{
    /// <summary>
    ///     Extension to call
    /// </summary>
    [AllowUpdate(false)]
    public required string IdExtensionOrNumber { get; set; }
}
