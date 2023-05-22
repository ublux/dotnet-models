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

    #endregion

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventOutgoingCallTerminatedWithAiAnalysis BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = GetRandomBase<EventOutgoingCallTerminatedWithAiAnalysis>(instance);

        obj.AiCallAnalysis = new AiCallAnalysisOutput()
        {
            IdAiCallAnalysisInput = AiCallAnalysisInput.BuildId(instance).Id,
            Output = new List<AiCallAnalysisVariableOutput>()
            {
                new AiCallAnalysisVariableOutput()
                {
                    Name = "Summary",
                    AiVariableType = AiVariableType.Text,
                    Value = "Client complains agains Agent that washing mashine is not working"
                },
                new AiCallAnalysisVariableOutput()
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
