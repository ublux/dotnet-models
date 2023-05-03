namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventIncomingCallTerminatedWithAiAnalysis"/>
/// </summary>
public class EventIncomingCallTerminatedWithAiAnalysis : EventIncomingCallTerminatedWithRecording
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventIncomingCallTerminatedWithAiAnalysis;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     AI Analysis
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required AiAnalysis AiAnalysis { get; set; } 

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallTerminatedWithAiAnalysis BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.GetRandomBase<EventIncomingCallTerminatedWithAiAnalysis>(instance);

        obj.AiAnalysis = new AiAnalysis()
        {
            Language = "English",
            AgentIntention = "Help client fix washing machine.",
            ClientIntention = "Complain about washing machine not working",
            AgentPolite = .95,
            ClientPolite = .71,
            ClientSatisfaction = 4,
            Entities = new List<AiEntity>()
            {
                new AiEntity()
                {
                    EntityName = "Washing Machine",
                    EntityType = "Object"
                },
                new AiEntity()
                {
                    EntityName = "Hotel",
                    EntityType = "Location"
                },
            },
            Model = "gpt-3.5-turbo",
            Problem = "Washing machine not working",
            Sentiment = new AiSentiment()
            {
                Negative = 25,
                Neutral = 5,
                Positive = 70

            },
            Summary = "Client is complaining about washing machine not working and agent tries to fix it.",
            Topics = new List<AiTopic>()
            {
                new AiTopic()
                {
                    Name = "Washing Machine",
                    Weight = .8
                }
            }
        };

        return obj;
    }
}
