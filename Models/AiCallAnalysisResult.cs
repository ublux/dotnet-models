namespace Ublux.Communications.Models;

/// <summary>
///     AI call analysis variable that AI engine outputs. Result of a query asked to AI angine.
/// </summary>
public class AiCallAnalysisResult : AiCallAnalysisVariable
{
    /// <summary>
    ///     Value of variable
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    ///     List of aditional outputs as a result of this output
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiCallAnalysisSubResult? SubResult { get; set; }
}

/// <summary>
///     Sub response
/// </summary>
public class AiCallAnalysisSubResult //: IAiCallAnalysisSubVariableOutput
{
    /// <summary>
    ///     List of aditional outputs as a result of this output
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiCallAnalysisResult> Results { get; set; } = new();
}


