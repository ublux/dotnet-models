namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeExtension
{
    /// <summary>
    ///     Extension to call
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string IdExtensionOrNumber { get; set; }
}
