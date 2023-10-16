namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventIncomingCallStarted"/>
/// </summary>
public class EventIncomingCallStarted : EventIncomingCallStartedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventIncomingCallStarted;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallStarted BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        return GetRandomBase<EventIncomingCallStarted>(instance);
    }
}
