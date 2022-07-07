namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Voicemail that was forwarded from one extension to another
/// </summary>
public partial class VoicemailForwarded : Voicemail
{
    /// <summary>
    ///     Type of voicemail
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public override VoicemailType VoicemailType => VoicemailType.Forwarded;

    /// <summary>
    ///     Line that forwarded this voicemail in case voicemail was forwarded
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Line))]
    [IsRequired]
    public required Line LineThatForwardedVoicemail { get; set; }

    /// <summary>
    ///     If voicemail is forwarded
    ///     To what extension was this voicemail forwarded to?
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Extension))]
    //[IsRequired]
    public Extension? ExtensionForwarded { get; set; }
}
