namespace Ublux.Communications.Models.Attributes;

/// <summary>
///     Properties with this attribute are required when being sent to API.
///     Also if its a list of something it must contain at least one item!
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class IsUbluxRequiredAttribute : Attribute
{
}
