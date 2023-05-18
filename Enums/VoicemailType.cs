namespace Ublux.Communications.Enums;

/// <summary>
///     Types of voicemail
/// </summary>
public enum VoicemailType
{
    /// <summary>
    ///     No type
    /// </summary>
    None,

    /// <summary>
    ///     Regular voicemail left on a UBLUX phone
    /// </summary>
    Regular,

    /// <summary>
    ///     When a voicemail is forwarded from one extension to another
    /// </summary>
    Forwarded
}
