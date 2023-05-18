namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventCallPlacedOnHoldFor4Min"/>
/// </summary>
public class EventCallPlacedOnHoldFor4Min : EventCallPlacedOnHoldBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventCallPlacedOnHoldFor4Min;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventCallPlacedOnHoldFor4Min BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.GetRandomBase<EventCallPlacedOnHoldFor4Min>(instance);
        return obj;
    }
}