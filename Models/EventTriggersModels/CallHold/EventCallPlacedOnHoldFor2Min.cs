namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTrigger.EventCallPlacedOnHoldFor2Min"/>
/// </summary>
public class EventCallPlacedOnHoldFor2Min : EventCallPlacedOnHoldBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventCallPlacedOnHoldFor2Min;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventCallPlacedOnHoldFor2Min BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.GetRandomBase<EventCallPlacedOnHoldFor2Min>(instance);
        return obj;
    }
}