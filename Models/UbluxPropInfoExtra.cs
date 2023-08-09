namespace Ublux.Communications.Models;

/// <summary>
///     Placed on Tag of UbluxPropInfo to store extra information
/// </summary>
public class UbluxPropInfoExtra
{
    /// <summary>
    ///     Is required?
    /// </summary>
    public bool IsRequired { get; set; }

    /// <summary>
    ///     Is it a string
    /// </summary>
    public bool IsString { get; set; }

    /// <summary>
    ///     Attribute UbluxValidationRequiredAttribute
    /// </summary>
    public UbluxValidationRequiredAttribute? UbluxValidationRequiredAttribute { get; set; }

    /// <summary>
    ///     Attribute UbluxValidationNotRequiredAttribute
    /// </summary>
    public UbluxValidationNotRequiredAttribute? UbluxValidationNotRequiredAttribute { get; set; }

    /// <summary>
    ///     Attribute UbluxValidationNotRequiredAttribute
    /// </summary>
    public UbluxValidationStringRangeAttribute? UbluxValidationStringRangeAttribute { get; set; }

    /// <summary>
    ///     If validating refences 
    /// </summary>
    public ReferencesAttribute? ReferencesAttribute { get; set; }

    /// <summary>
    ///     Error message if null
    /// </summary>
    public string BuildErrorMessageIfNull(string propertyName)
    {
        if (UbluxValidationRequiredAttribute != null && UbluxValidationRequiredAttribute.CustomErrorMessage != null)
            return UbluxValidationRequiredAttribute.CustomErrorMessage.Replace("path", propertyName);
        return $"'{propertyName}' cannot be null or empty";
    }

    /// <summary>
    ///     Error message if required
    /// </summary>
    public string BuildErrorMessageIfRequired(string propertyName)
    {
        if (UbluxValidationRequiredAttribute != null && UbluxValidationRequiredAttribute.CustomErrorMessage != null)
            return UbluxValidationRequiredAttribute.CustomErrorMessage.Replace("path", propertyName);
        return $"'{propertyName}' value is required";
    }

    /// <summary>
    ///     Error message if string range 
    /// </summary>
    public string BuildErrorMessageIfRange(string propertyName, int min, int max)
    {
        if (UbluxValidationStringRangeAttribute != null && UbluxValidationStringRangeAttribute.CustomErrorMessage != null)
            return UbluxValidationStringRangeAttribute.CustomErrorMessage.Replace("path", propertyName);
        return $"'{propertyName}' value lenght must be between {min} and {max} characters";
    }
} 
