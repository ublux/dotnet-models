namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventIncomingCallTerminatedWithAiAnalysis"/>
/// </summary>
public class EventIncomingCallTerminatedWithAiAnalysis : EventIncomingCallTerminatedWithRecording
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventIncomingCallTerminatedWithAiAnalysis;
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
    public override EventIncomingCallTerminatedWithAiAnalysis BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = GetRandomBase<EventIncomingCallTerminatedWithAiAnalysis>(instance);

        obj.AiCallAnalysis = new ()
        {
            IdAiCallAnalysisInput = AiCallAnalysisInput.BuildId(instance).Id,
            Results = new ()
            {
                new ()
                {
                    Name = "Summary",
                    AiVariableType = AiVariableType.Text,
                    Value = "Client complains agains Agent that washing mashine is not working"
                },
                new ()
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
