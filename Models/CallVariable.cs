namespace Ublux.Communications.Models;

/// <summary>
///     Call variable
/// </summary>
public class CallVariable
{
    /// <summary>
    ///     Variable name
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    ///     Variable value. Supports JSON format
    /// </summary>
    public string? Value { get; set; }
}
