namespace Ublux.Communications.Models;

/// <summary>
///     Represents a validation error.
/// </summary>
public class ValidationError
{
    /// <summary>
    ///     Name of property containing error.
    /// </summary>
    [IsRequired]
    [AllowUpdate(false)]
    public string PropertyName { get; set; } = string.Empty;

    /// <summary>
    ///     Value of property containing error.
    /// </summary>    
    [AllowUpdate(false)]
    public object? PropertyValue { get; set; }

    /// <summary>
    ///     Error message
    /// </summary>    
    [AllowUpdate(false)]
    public string? ErrorMessage { get; set; }

}
