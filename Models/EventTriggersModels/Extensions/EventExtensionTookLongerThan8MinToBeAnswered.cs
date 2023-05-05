namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTrigger.EventExtensionTookLongerThan8MinToBeAnswered"/>
/// </summary>
public class EventExtensionTookLongerThan8MinToBeAnswered : EventExtensionBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventExtensionTookLongerThan8MinToBeAnswered;
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