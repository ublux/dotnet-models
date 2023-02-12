namespace Ublux.Communications.Models;

/// <summary>
///     Represents a validation error.
/// </summary>
[DebuggerDisplay("PropertyName={PropertyName} PropertyValue={PropertyValue} ErrorMessage={ErrorMessage}")]
public class ValidationError
{
    /// <summary>
    ///     Name of property containing error.
    /// </summary>
    //[IsUbluxRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? PropertyName { get; set; }

    /// <summary>
    ///     Value of property containing error.
    /// </summary>    
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public object? PropertyValue { get; set; }

    /// <summary>
    ///     Error message
    /// </summary>    
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? ErrorMessage { get; set; }
}
