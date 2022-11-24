namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     All webhook events must inherit from this
/// </summary>
public abstract class EventTriggerModel
{
    /// <summary>
    ///     Type of event. It only
    /// </summary>
    public abstract EventTrigger EventTrigger
    {
        get;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set;
    }
}

