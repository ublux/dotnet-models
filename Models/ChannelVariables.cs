namespace Ublux.Communications.Models;

/// <summary>
///     A phone call with two peers are composed from the union of two channels. Each channel has its variables
/// </summary>
public class ChannelVariables
{
    /// <summary>
    ///     Language. For example if you leave a voicemail to an extension that has default settings 
    ///     then the greeting message will be played to the caller in this language
    /// </summary>
    [UbluxValidationRequired]
    public Language Language { get; set; }

    /// <summary>
    ///     Music on hold. This is the music that will be played when the call is placed on hold.
    /// </summary>
    public string? IdMusicOnHoldGroup { get; set; }

    /// <summary>
    ///     Caller id is composed of a name and phone number. This is the name part of the caller id
    /// </summary>
    [UbluxValidationRequired]
    public required string CallerIdName { get; set; }

    /// <summary>
    ///     Caller id is composed of a name and phone number. This is the phone number part of the caller id
    /// </summary>
    [UbluxValidationRequired]
    public required string CallerIdNumber { get; set; }    
}
