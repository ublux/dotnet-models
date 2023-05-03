﻿namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventCallPlacedOnHoldFor1Min"/>
/// </summary>
public class EventCallPlacedOnHoldFor1Min : EventCallPlacedOnHoldBase
{
    /// <summary>
    ///     Event Trigger Type
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventCallPlacedOnHoldFor1Min;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventCallPlacedOnHoldFor1Min BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = base.GetRandomBase<EventCallPlacedOnHoldFor1Min>(instance);
        return obj;
    }
}
