namespace Ublux.Communications.Models;

/// <summary>
///     AI call analysis variable query sent to AI engine
/// </summary>
public class AiCallAnalysisVariableInput : AiCallAnalysisVariableOutput
{
    /// <summary>
    ///     Question to ask AI engine about conversation. For example: Client satisfaction with integer value ranging from 1 to 5
    /// </summary>
    [UbluxValidationStringRange(0, 5_000)]
    public required string Query { get; set; }
}

