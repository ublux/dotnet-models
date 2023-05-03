namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventOutgoingCallTerminatedWithTranscription"/>
/// </summary>
public partial class EventOutgoingCallTerminatedWithTranscription : EventOutgoingCallTerminatedWithRecording
{
    /// <inheritdoc />
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override EventTrigger EventTrigger
    {
        get => EventTrigger.EventOutgoingCallTerminatedWithTranscription;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     If there is a language it means there is a transcription
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? TranscriptionLanguage { get; set; }

    /// <summary>
    ///     Audio of agent converted to text
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiTranscription> Transcription { get; set; } = new();

    /// <summary>
    ///     If the transcription contains an error
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventOutgoingCallTerminatedWithTranscription BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var obj = GetRandomBase<EventOutgoingCallTerminatedWithTranscription>(instance);

        // transcription
        obj.TranscriptionLanguage = "English";
        obj.Transcription.Add(new AiTranscription()
        {
            Speaker = "Agent",
            Text = "Hello how are you?",
            StartTime = 1,
            EndTime = 5
        });
        obj.Transcription.Add(new AiTranscription()
        {
            Speaker = "Client",
            Text = "Great thanks!",
            StartTime = 6,
            EndTime = 10
        });
        obj.Transcription.Add(new AiTranscription()
        {
            Speaker = "Agent",
            Text = "I have to go calling you soon!",
            StartTime = 11,
            EndTime = 15
        });
        obj.Transcription.Add(new AiTranscription()
        {
            Speaker = "Client",
            Text = "OK call me later. Have a great day.",
            StartTime = 16,
            EndTime = 21
        });

        return obj;
    }
}
