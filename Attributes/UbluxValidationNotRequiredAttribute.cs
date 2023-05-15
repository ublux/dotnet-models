namespace Ublux.Communications.Attributes;

/// <summary>
///     Used to override the UbluxValidationRequiredAttribute.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class UbluxValidationNotRequiredAttribute : Attribute
{
}
