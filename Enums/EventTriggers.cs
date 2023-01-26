namespace Ublux.Communications.Enums;

/// <summary>
///     Type of events that could trigger a custom action
/// </summary>
public enum EventTrigger
{
    #region Call terminated

    /// <summary/>
    event_outgoing_call_terminated,
    /// <summary/>
    event_incoming_call_terminated,

    /// <summary/>
    event_outgoing_call_terminated_with_recording,
    /// <summary/>
    event_incoming_call_terminated_with_recording,

    #endregion

    #region Calls

    /// <summary/>
    event_call_placed_on_hold_for_1_min,
    /// <summary/>
    event_call_placed_on_hold_for_2_min,
    /// <summary/>
    event_call_placed_on_hold_for_4_min,
    /// <summary/>
    event_call_placed_on_hold_for_8_min,

    #endregion


    #region Line connected/disconnected

    /// <summary/>
    event_line_disconnected,
    /// <summary/>
    event_line_connected,

    #endregion

    #region Extension

    /// <summary/>
    event_extension_not_answered,

    /// <summary/>
    event_extension_took_to_longer_than_1_min_to_be_answered,
    /// <summary/>
    event_extension_took_to_longer_than_2_min_to_be_answered,
    /// <summary/>
    event_extension_took_to_longer_than_4_min_to_be_answered,
    /// <summary/>
    event_extension_took_to_longer_than_8_min_to_be_answered,

    #endregion




    ///// <summary/>
    //event_phone_created,
    ///// <summary/>
    //event_phone_updated,
    ///// <summary/>
    //event_phone_deleted,
    ///// <summary/>
    //event_phone_line_created,
    ///// <summary/>
    //event_phone_line_deleted,


    ///// <summary/>
    //event_extension_created,
    ///// <summary/>
    //event_extension_updated,
    ///// <summary/>
    //event_extension_deleted,
    ///// <summary/>

    //// only  needed the created event for web hooks page. 
    ///// <summary/>
    //event_power_dialer_created,
    ///// <summary/>
    //event_power_dialer_changed
}
