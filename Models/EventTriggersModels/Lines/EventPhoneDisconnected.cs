namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventPhoneDisconnected"/>
/// </summary>
public class EventPhoneDisconnected : EventPhoneBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventPhoneDisconnected;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventPhoneDisconnected BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.RandomBase<EventPhoneDisconnected>(instance);
        obj.ConnectionStatus!.IsConnected = true;

        return obj;
    }
}
