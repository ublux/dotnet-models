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
    [UbluxValidationIsRequired]
    public required string Name { get; set; }

    /// <summary>
    ///     Value of variable. It can be in json or anything
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(4000)]
    public string? Value { get; set; }
}


