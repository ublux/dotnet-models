namespace Ublux.Communications.Models.EventTriggersModels;

/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contains web hooks models */

/// <summary />
public partial class EventOutgoingCallTerminated : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_outgoing_call_terminated;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventIncomingCallTerminated : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_incoming_call_terminated;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventOutgoingCallTerminatedWithRecording : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_outgoing_call_terminated_with_recording;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventIncomingCallTerminatedWithRecording : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_incoming_call_terminated_with_recording;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventCallPlacedOnHoldForTooLong : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_call_placed_on_hold_for_too_long;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventLineDisconnected : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_line_disconnected;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventLineConnected : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_line_connected;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventExtensionNotAnswered : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_extension_not_answered;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class EventExtensionTookToLongToBeAnswered : EventTriggerModel
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_extension_took_to_long_to_be_answered;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

