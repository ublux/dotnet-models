namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
    public string IdLineThatForwardedVoicemail { get; set; } = string.Empty;

    /// <summary>
    ///     If voicemail is forwarded
    ///     To what extension was this voicemail forwarded to
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Extension))]
    [IsRequired]
    public string IdExtensionForwarde { get; set; } = string.Empty;
}
