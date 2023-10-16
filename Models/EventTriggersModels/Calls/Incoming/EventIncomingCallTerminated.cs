namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventIncomingCallTerminated"/>
/// </summary>
public class EventIncomingCallTerminated : EventIncomingCallEndedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventIncomingCallTerminated;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallTerminated BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        return GetRandomBase<EventIncomingCallTerminated>(instance);
    }
}
