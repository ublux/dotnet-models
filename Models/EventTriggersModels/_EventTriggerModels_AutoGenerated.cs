namespace Ublux.Communications.Models.EventTriggersModels;

/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contains web hooks models */

/// <summary />
public partial class OutgoingCallTerminated : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_outgoing_call_terminated;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class IncomingCallTerminated : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_incoming_call_terminated;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class OutgoingCallTerminatedWithRecording : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_outgoing_call_terminated_with_recording;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class IncomingCallTerminatedWithRecording : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_incoming_call_terminated_with_recording;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class LineDisconnected : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_line_disconnected;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class LineConnected : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_line_connected;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class ExtensionDialNotAnswered : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_extension_dial_not_answered;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class ExtensionQueueNotAnswered : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_extension_queue_not_answered;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class ExtensionQueueTookToLongToBeAnswered : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_extension_queue_took_to_long_to_be_answered;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

/// <summary />
public partial class CallPlacedOnHoldForTooLong : EventTriggerModel
{
    /// <inheritdoc />
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.event_call_placed_on_hold_for_too_long;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}

