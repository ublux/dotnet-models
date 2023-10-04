namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventOutgoingCallTerminatedWithAiAnalysis"/>
/// </summary>
public class EventOutgoingCallTerminatedWithAiAnalysis : EventOutgoingCallTerminatedWithRecording
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventOutgoingCallTerminatedWithAiAnalysis;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    #region AI Analysis

    /// <summary>
    ///     Detected language
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required AiCallAnalysisOutput AiCallAnalysis { get; set; }

    /// <summary>
    ///     Most AI call analysis contain a summary. Sending it outside the array make's it easy to get
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? AiCallAnalysisSummary { get; set; }

    /// <summary>
    ///     Most AI call analysis contains Categories. Sending it outside the array make's it easy to get
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? AiCallAnalysisCategories { get; set; }

    /// <summary>
    ///     Most AI call analysis contain sentiment. Sending it outside the array make's it easy to get
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? AiCallAnalysisSentiment { get; set; }

    /// <summary>
    ///     Most AI call analysis contain a problem. Sending it outside the array make's it easy to get
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? AiCallAnalysisProblem { get; set; }

    #endregion

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventOutgoingCallTerminatedWithAiAnalysis BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        EventOutgoingCallTerminatedWithAiAnalysis obj = GetRandomBase<EventOutgoingCallTerminatedWithAiAnalysis>(instance);

        obj.AiCallAnalysis = new ()
        {
            IdAiCallAnalysisInput = AiCallAnalysisInput.BuildId(instance).Id,
            Results = new ()
            {
                new AiCallAnalysisResult()
                {
                    Name = "Summary",
                    AiVariableType = AiVariableType.Text,
                    Value = "Client complains agains Agent that washing mashine is not working"
                },
                new AiCallAnalysisResult()
                {
                    Name = "CustomerSatisfaction",
                    AiVariableType = AiVariableType.Integer,
                    Value = "3"
                }
            },
            DetectedLanguage = "English"           
        };
        return obj;
    }
}
