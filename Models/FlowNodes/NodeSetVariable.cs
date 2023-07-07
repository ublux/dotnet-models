namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeSetVariable
{
    /// <summary>
    ///     Name of varieble
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    ///     Value of variable
    /// </summary>
    public required string Value { get; set; }
}

