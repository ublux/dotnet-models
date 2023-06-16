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
    [UbluxValidationRequired]
    [HideForCreateRequest]
    public override VoicemailType VoicemailType => VoicemailType.Forwarded;

    /// <summary>
    ///     Phone that forwarded this voicemail in case voicemail was forwarded
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required Phone PhoneThatForwardedVoicemail { get; set; }

    /// <summary>
    ///     (CallerIdNumber when voicemail was forwarded)
    ///     Extension number where voicemail was forwarded. For example 100 meaning that extension 100 forwarded this voicemail.    
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ForwardedFrom { get; set; }
}
