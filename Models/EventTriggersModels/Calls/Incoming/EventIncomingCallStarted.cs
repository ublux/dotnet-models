namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTrigger.EventIncomingCallStarted"/>
/// </summary>
public class EventIncomingCallStarted : EventIncomingCallStartedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventIncomingCallStarted;
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
        return base.GetRandomBase<EventIncomingCallStarted>(instance);
    }
}
