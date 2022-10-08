namespace Ublux.Communications.Models.Attributes;

/// <summary>
///     Properties with this attribute are required when being sent to API
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class IsUbluxRequiredAttribute : Attribute
{
}
