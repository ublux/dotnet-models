namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Webhook will send this data when triggered.
///     <see cref="EventTriggerType.EventIncomingCallTerminatedWithRecording"/>
/// </summary>
public class EventIncomingCallTerminatedWithRecording : EventIncomingCallEndedBase
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTriggerType EventTrigger
    {
        get => EventTriggerType.EventIncomingCallTerminatedWithRecording;
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
    public override EventIncomingCallTerminatedWithRecording BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        return this.GetRandomBase< EventIncomingCallTerminatedWithRecording>(instance);
    }

    /// <summary>
    ///     Return a random object
    /// </summary>
    protected new T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventIncomingCallTerminatedWithRecording
    {
        var obj = base.GetRandomBase<T>(instance);
        // var idAccBuild = Account.BuildId(Random.Shared.Next(100, 10000).ToString());
        obj.RecordingUrl = "https://api.ublux.com/StoredFile/" + Guid.NewGuid().ToString() + ".mp3";
        return obj;
    }


}
