namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventCallPlacedOnHoldFor1Min"/>
/// </summary>
public class EventCallPlacedOnHoldFor1Min : EventCallPlacedOnHoldBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventCallPlacedOnHoldFor1Min;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventCallPlacedOnHoldFor1Min BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = GetRandomBase<EventCallPlacedOnHoldFor1Min>(instance);
        return obj;
    }
}
