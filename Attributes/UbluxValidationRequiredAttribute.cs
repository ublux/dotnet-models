namespace Ublux.Communications.Attributes;

/// <summary>
///     Properties with this attribute are required when being sent to API.
///     
///     - If its a list of something it must contain at least one item!
///     - If its a value type it cannot contain its default value and that is including Enums! So if an enum contains this attribute it cannot have its defult value
///     - Booleans can have default value of false
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class UbluxValidationRequiredAttribute : Attribute
{
    /// <summary>
    ///     Custom error message
    /// </summary>
    public string? CustomErrorMessage { get; }

    /// <summary>
    ///     Constructor
    /// </summary>    
    public UbluxValidationRequiredAttribute(string? customErrorMessage = null)
    {
        CustomErrorMessage = customErrorMessage;
    }
}
