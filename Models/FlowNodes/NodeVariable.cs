namespace Ublux.Communications.Models.FlowNodes;

/// <summary>
///     A variable is usualy some time of json object
/// </summary>
public partial class NodeVariable
{
    /// <summary>
    ///     Variable name
    /// </summary>
    public required string Name { get; set; }

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

