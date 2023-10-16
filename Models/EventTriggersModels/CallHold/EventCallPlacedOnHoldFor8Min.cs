namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventCallPlacedOnHoldFor8Min"/>
/// </summary>
public class EventCallPlacedOnHoldFor8Min : EventCallPlacedOnHoldBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventCallPlacedOnHoldFor8Min;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventCallPlacedOnHoldFor8Min BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = GetRandomBase<EventCallPlacedOnHoldFor8Min>(instance);
        return obj;
    }
}