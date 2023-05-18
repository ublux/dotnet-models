namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventExtensionTookLongerThan1MinToBeAnswered"/>
/// </summary>
public class EventExtensionTookLongerThan1MinToBeAnswered : EventExtensionBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventExtensionTookLongerThan1MinToBeAnswered;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventExtensionNotAnswered BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        return GetRandomBase<EventExtensionNotAnswered>(instance);
    }
}