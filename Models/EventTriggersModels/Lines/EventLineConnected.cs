namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventLineConnected"/>
/// </summary>
public class EventLineConnected : EventLineBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventLineConnected;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventLineConnected BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.RandomBase<EventLineConnected>(instance);
        obj.ConnectionStatus!.IsConnected = true;

        return obj;
    }
}
