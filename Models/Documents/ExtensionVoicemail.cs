﻿namespace Ublux.Communications.Models.Documents;

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
    ///     Phones that can listen to this voicemail on their phones. It is also possible to listen to voicemails through phones and not just email.
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(true)]
    public List<string> IdsPhonesThatCanListenToVoicemail { get; set; } = [];

    #endregion

    /// <summary>
    ///     Emails where to send the voicemail
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    [References(typeof(Email))]
    public required string IdEmail { get; set; } = string.Empty;

    /// <summary>
    ///     This text will be converted to audio and be played before leaving voicemail
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(2000)]
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
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public override ExtensionType ExtensionType
    {
        get => ExtensionType.Voicemail;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
