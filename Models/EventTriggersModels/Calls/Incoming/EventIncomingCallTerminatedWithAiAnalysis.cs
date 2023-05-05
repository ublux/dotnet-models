namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
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

    #region AI Analysis

    /// <summary>
    ///     Sentiment of phone call in percentages
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public AiSentiment? Sentiment { get; set; }

    /// <summary>
    ///     Entities mentioned in the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiEntity> Entities { get; set; } = new();

    /// <summary>
    ///     Topics mentioned in the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiTopic> Topics { get; set; } = new();

    /// <summary>
    ///     Intention of client summarized
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ClientIntention { get; set; }

    /// <summary>
    ///     Intention of agent summarized
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? AgentIntention { get; set; }

    /// <summary>
    ///     Summary of conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? Summary { get; set; }

    /// <summary>
    ///     Problem of the conversation
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? Problem { get; set; }

    /// <summary>
    ///     Was client polite? This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? ClientPolite { get; set; }

    /// <summary>
    ///     Was agent polite? This is a value between 0 and 1 representing a percentage.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? AgentPolite { get; set; }

    /// <summary>
    ///     Client satisfaction from 1 to 5.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int ClientSatisfaction { get; set; }

    /// <summary>
    ///     Detected language
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string Language { get; set; } = "";

    #endregion

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallTerminatedWithAiAnalysis BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.GetRandomBase<EventIncomingCallTerminatedWithAiAnalysis>(instance);

        obj.Language = "English";
        obj.AgentIntention = "Help client fix washing machine.";
        obj.ClientIntention = "Complain about washing machine not working";
        obj.AgentPolite = .95;
        obj.ClientPolite = .71;
        obj.ClientSatisfaction = 4;
        obj.Entities = new List<AiEntity>()
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
            };
        obj.Problem = "Washing machine not working";
        obj.Sentiment = new AiSentiment()
        {
            Negative = 25,
            Neutral = 5,
            Positive = 70

        };
        obj.Summary = "Client is complaining about washing machine not working and agent tries to fix it.";
        obj.Topics = new List<AiTopic>()
        {
            new AiTopic()
            {
                Name = "Washing Machine",
                Weight = .8
            }
        };

        return obj;
    }
}
