namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeVariable
{
    /// <summary>
    ///     Path to json. Example:  students[10].firstName;
    /// </summary>
    public required string Path { get; set; }

    /// <summary>
    ///     Euals this value
    /// </summary>
    public string? Equal { get; set; } = null;

    /// <summary>
    ///     Contains this value
    /// </summary>
    public string? Contains { get; set; }
}

