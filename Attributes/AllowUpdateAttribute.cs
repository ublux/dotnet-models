namespace Ublux.Communications.Attributes;

/// <summary>
///     Properties containing this attribute will be allowed to be updated
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class AllowUpdateAttribute : Attribute
{
    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="allow"></param>
    public AllowUpdateAttribute(bool allow)
    {
        Allow = allow;
    }

    /// <summary>
    ///     Allow to update property?
    /// </summary>
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public bool Allow { get; set; } 
}
