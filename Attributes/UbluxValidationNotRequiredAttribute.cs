namespace Ublux.Communications.Attributes;

/// <summary>
///     Used to override the UbluxValidationRequiredAttribute.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class UbluxValidationNotRequiredAttribute : Attribute;
