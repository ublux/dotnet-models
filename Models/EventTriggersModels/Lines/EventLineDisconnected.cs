﻿namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventLineDisconnected"/>
/// </summary>
public partial class EventLineDisconnected : EventLineBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventLineDisconnected;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventLineDisconnected BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.RandomBase<EventLineDisconnected>(instance);
        obj.ConnectionStatus!.IsConnected = true;

        return obj;
    }
}