namespace Ublux.Communications.Domain.Attributes;

/// <summary>
///     Properties containing this attribute will not be shown on swagger documentation.
///     For example when creating a new Phone we do not want to see the property DateCreated
/// </summary>
public class HideForCreateRequestAttribute : Attribute
{
}
