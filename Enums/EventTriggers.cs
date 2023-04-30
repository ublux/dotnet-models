namespace Ublux.Communications.Enums;

/// <summary>
///     Type of events that could trigger a custom action. 
///     Used by Zapier and Integromat
/// </summary>
public enum EventTrigger
{
    #region Call terminated/started

    /// <summary/>
    EventOutgoingCallTerminated,
    /// <summary/>
    EventIncomingCallTerminated,

    /// <summary/>
    EventOutgoingCallTerminatedWithRecording,
    /// <summary/>
    EventIncomingCallTerminatedWithRecording,

    /// <summary/>
    EventOutgoingCallStarted,
    /// <summary/>
    EventIncomingCallStarted,

    #endregion

    #region Calls

    /// <summary/>
    EventCallPlacedOnHoldFor1Min,
    /// <summary/>
    EventCallPlacedOnHoldFor2Min,
    /// <summary/>
    EventCallPlacedOnHoldFor4Min,
    /// <summary/>
    EventCallPlacedOnHoldFor8Min,

    #endregion

    #region Line connected/disconnected

    /// <summary/>
    EventLineDisconnected,
    /// <summary/>
    EventLineConnected,

    #endregion

    #region Extension

    /// <summary/>
    EventExtensionNotAnswered,

    /// <summary/>
    EventExtensionTookLongerThan1MinToBeAnswered,
    /// <summary/>
    EventExtensionTookLongerThan2MinToBeAnswered,
    /// <summary/>
    EventExtensionTookLongerThan4MinToBeAnswered,
    /// <summary/>
    EventExtensionTookLongerThan8MinToBeAnswered,

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
