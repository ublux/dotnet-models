namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventOutgoingCallTerminatedWithRecording"/>
/// </summary>
public class EventOutgoingCallTerminatedWithRecording : EventOutgoingCallEndedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventOutgoingCallTerminatedWithRecording;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Recording of call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string RecordingUrl { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventOutgoingCallTerminatedWithRecording BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        return this.GetRandomBase<EventOutgoingCallTerminatedWithRecording>(instance);
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    protected new T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventOutgoingCallTerminatedWithRecording
    {
        var obj = base.GetRandomBase<T>(instance);        
        obj.RecordingUrl = "https://api.ublux.com/StoredFile/" + Guid.NewGuid().ToString() + ".mp3";

        return obj;
    }
}
