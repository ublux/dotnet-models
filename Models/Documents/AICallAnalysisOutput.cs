namespace Ublux.Communications.Models.Documents;

/// <summary>
///     AI output of analysed call
/// </summary>
public class AiCallAnalysisOutput
{
    /// <summary>
    ///     What input was passed to get this output?
    /// </summary>
    [UbluxValidationRequired]
    [References(typeof(AiCallAnalysisInput))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string IdAiCallAnalysisInput { get; set; } = "";

    /// <summary>
    ///     Detected language on call conversation
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string DetectedLanguage { get; set; } 

    /// <summary>
    ///     List of queries to ask AI engine about a call
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiCallAnalysisVariableOutput> Output { get; set; } = new();

}