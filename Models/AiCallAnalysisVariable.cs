namespace Ublux.Communications.Models;

/// <summary>
///     AI call analysis variable that AI engine outputs
/// </summary>
public abstract class AiCallAnalysisVariable
{
    /// <summary>
    ///     There cannot be two variable names with the same name
    /// </summary>
    [UbluxValidationNotRequired]
    public required string Name { get; set; }

    /// <summary>
    ///     Type of variable. There are some that are complex that are predefined such as Sentiment that contains positive, neutral and negative values.
    /// </summary>
    [UbluxValidationNotRequired]
    public AiVariableType AiVariableType { get; set; }

    /// <summary>
    ///     Description about query. This will be included when sending an email as helpful data
    /// </summary>
    [UbluxValidationStringRange(0, 2_000)]
    public string? Description { get; set; }
}

