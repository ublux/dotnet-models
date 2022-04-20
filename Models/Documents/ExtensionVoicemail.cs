namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Calling this extension will enable to store a voicemail and be sent via email
/// </summary>
public partial class ExtensionVoicemail : Extension
{
    #region Properties

    #region References

    /// <summary>
    ///     Optional audio to play before leaving voicemail
    /// </summary>
    [References(typeof(Audio))]
        [AllowUpdate(true)]
    public string? IdAudio { get; set; }

    /// <summary>
    ///     Lines that can listen to this voicemail on their phones. It is also possible to listen to voicemails through phones and not just email.
    /// </summary>
    [References(typeof(Line))]
        [AllowUpdate(true)]
    public List<string> IdsLinesThatCanListenToVoicemail
    {
        get => _IdsLinesThatCanListenToVoicemail;
        set { if (value is null) _IdsLinesThatCanListenToVoicemail.Clear(); else _IdsLinesThatCanListenToVoicemail = value; }
    }
    List<string> _IdsLinesThatCanListenToVoicemail = new();
    #endregion

    /// <summary>
    ///     Emails where to send the voicemail
    /// </summary>
        [AllowUpdate(true)]
    [Required]
    public List<string> Email
    {
        get => _Email;
        set { if (value is null) _Email.Clear(); else _Email = value; }
    }
    List<string> _Email = new();

    /// <summary>
    ///     This text will be converted to audio and be played before leaving voicemail
    /// </summary>
        [AllowUpdate(true)]
    public string? TextToSpeech { get; set; }

    /// <summary>
    ///     If using tts (text to speech) then what voice id to use with amazon? Joana?
    /// </summary>
        [AllowUpdate(true)]
    public string? TextToSpeechVoiceId { get; set; }

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)]
        [Required]
    [HideForCreateRequest]
    public override ExtensionType ExtensionType => ExtensionType.Voicemail;
}
