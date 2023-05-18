namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventOutgoingCallStarted"/>
/// </summary>
public partial class EventOutgoingCallStarted : EventOutgoingCallStartedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventOutgoingCallStarted;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventOutgoingCallStarted BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.GetRandomBase<EventOutgoingCallStarted>(instance);
        return obj;
    }
}
