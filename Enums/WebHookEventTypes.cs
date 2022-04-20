namespace Ublux.Communications.Enums;

/// <summary>
///     Type of events that could trigger a custom action
/// </summary>
public enum WebHookEvent
{
    // lines_ringing
    /// <summary/>
    event_channel_terminated,
    /// <summary/>
    event_outoing_call,
    /// <summary/>
    event_incoming_call,
    /// <summary/>
    event_call_answered,

    /// <summary/>
    event_phone_disconnected_from_webapp,
    /// <summary/>
    event_phone_connected_to_webapp,

    /// <summary/>
    event_click_to_dial_chrome_extension,

    /// <summary/>
    event_phone_created,
    /// <summary/>
    event_phone_updated,
    /// <summary/>
    event_phone_deleted,
    /// <summary/>
    event_phone_line_created,
    /// <summary/>
    event_phone_line_deleted,


    /// <summary/>
    event_extension_created,
    /// <summary/>
    event_extension_updated,
    /// <summary/>
    event_extension_deleted,
    /// <summary/>

    event_line_key_group_updated,

    /// <summary/>
    event_phone_configuration_updated,
    /// <summary/>
    event_phone_configuration_deleted,

    /// <summary/>
    event_phone_connected,
    /// <summary/>
    event_phone_disconnected,

    // fires when extension dial is not answered.
    /// <summary/>
    event_extension_dial_not_answered,
    /// <summary/>
    event_extension_queue_not_answered,

    // only  needed the created event for web hooks page. 
    /// <summary/>
    event_power_dialer_created,
    /// <summary/>
    event_power_dialer_changed



}
