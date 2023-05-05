namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTrigger.EventOutgoingCallTerminated"/>
/// </summary>
public partial class EventOutgoingCallTerminated : EventOutgoingCallEndedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventOutgoingCallTerminated;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventOutgoingCallTerminated BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = this.GetRandomBase<EventOutgoingCallTerminated>(instance);
        return obj;
    }
}
