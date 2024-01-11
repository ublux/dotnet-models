namespace Ublux.Communications.Models.Documents;

/// <summary>
///     AI output of analyzed call
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
    public List<AiCallAnalysisResult> Results { get; set; } = [];

    /// <summary>
    ///     Total tokes used by AI engine
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public int TokensTotal { get; set; }

    /// <summary>
    ///     Tokens used by completion on AI engine
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public int TokensCompletion { get; set; }

    /// <summary>
    ///     Tokens used by prompt on AI engine
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public int TokensPrompt { get; set; }
}