namespace Ublux.Communications.Attributes;

/// <summary>
///     Helper method
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class ReferencesAttribute : Attribute
{
    /// <summary>
    ///     The type of class it references
    /// </summary>
    public Type ReferenceType { get; set; }

    /// <summary>
    ///     Constructor
    /// </summary>
    public ReferencesAttribute(Type referenceType)
    {
        ReferenceType = referenceType;
    }
}
