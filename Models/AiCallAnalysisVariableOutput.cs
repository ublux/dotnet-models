namespace Ublux.Communications.Models;

/// <summary>
///     AI call analysis variable that AI engine outputs
/// </summary>
public class AiCallAnalysisVariableOutput
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
    ///     Value of variable
    /// </summary>
    public string? Value { get; set; }
}

