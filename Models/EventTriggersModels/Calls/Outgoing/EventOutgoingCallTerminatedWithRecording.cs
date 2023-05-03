namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventOutgoingCallTerminatedWithRecording"/>
/// </summary>
public partial class EventOutgoingCallTerminatedWithRecording : EventOutgoingCallEndedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventOutgoingCallTerminatedWithRecording;
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
