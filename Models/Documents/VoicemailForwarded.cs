namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Voicemail that was forwarded from one extension to another. There are times when people want to send their voicemail from one another.
/// </summary>
public partial class VoicemailForwarded : Voicemail
{
    /// <summary>
    ///     Type of voicemail
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public override VoicemailType VoicemailType => VoicemailType.Forwarded;

    /// <summary>
    ///     Line that forwarded this voicemail in case voicemail was forwarded
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    //[References(typeof(Line))]
    [IsUbluxRequired]
    public required Line LineThatForwardedVoicemail { get; set; }

    /// <summary>
    ///     If voicemail is forwarded
    ///     To what extension was this voicemail forwarded to?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    //[References(typeof(Extension))]
    //[IsUbluxRequired]
    public Extension? ExtensionForwarded { get; set; }
}
