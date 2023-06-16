namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventPhoneConnected"/>
/// </summary>
public class EventPhoneConnected : EventPhoneBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventPhoneConnected;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventPhoneConnected BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.RandomBase<EventPhoneConnected>(instance);
        obj.ConnectionStatus!.IsConnected = true;

        return obj;
    }
}
