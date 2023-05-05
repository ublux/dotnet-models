﻿namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTrigger.EventIncomingCallTerminated"/>
/// </summary>
public class EventIncomingCallTerminated : EventIncomingCallEndedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventIncomingCallTerminated;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallTerminated BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        return base.GetRandomBase<EventIncomingCallTerminated>(instance);
    }
}
