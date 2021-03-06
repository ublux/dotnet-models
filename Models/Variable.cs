namespace Ublux.Communications.Models;

/// <summary>
///     Variable to store custom data about a customer
/// </summary>
public class Variable
{
    /// <summary>
    ///     Name of variable
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required string Name { get; set; }

    /// <summary>
    ///     Value of variable in json format
    /// </summary>
    [AllowUpdate(true)]
    public string? JsonValue { get; set; }
}


