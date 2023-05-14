namespace Ublux.Communications.Attributes;

/// <summary>
///     Ensures a string length is between a minimum and maximum length.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class UbluxValidationStringRangeAttribute : Attribute
{
    /// <summary>
    ///     Max length
    /// </summary>
    public int MaxLength { get; }

    /// <summary>
    ///     Min length
    /// </summary>
    public int MinLength { get; }

    /// <summary>
    ///     Constructor
    /// </summary>
    public UbluxValidationStringRangeAttribute(int maxLength = DefaultMaximumIfNotSpecifiedOnString)
    {
        MinLength = 0;
        MaxLength = maxLength;
    }

    /// <summary>
    ///     Constructor
    /// </summary>
    public UbluxValidationStringRangeAttribute(int minLength, int maxLength)
    {
        MinLength = minLength;
        MaxLength = maxLength;
    }

    /// <summary>
    ///     Default for not specified strings
    /// </summary>
    public const int DefaultMaximumIfNotSpecifiedOnString = 100;
}


