namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTrigger.EventCallPlacedOnHoldFor8Min"/>
/// </summary>
public class EventCallPlacedOnHoldFor8Min : EventCallPlacedOnHoldBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventCallPlacedOnHoldFor8Min;
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
        var obj = this.GetRandomBase<EventCallPlacedOnHoldFor8Min>(instance);
        return obj;
    }
}