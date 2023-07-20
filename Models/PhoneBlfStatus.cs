namespace Ublux.Communications.Models;

/// <summary>
///     BLF status of a phone
/// </summary>
public class PhoneBlfStatus
{
    /// <summary>
    ///     Id of phone
    /// </summary>
    [UbluxValidationRequired]
    [References(typeof(Phone))]
    public required string IdPhone { get; set; }

    /// <summary>
    ///     Id of channel
    /// </summary>
    [UbluxValidationRequired]
    public required string IdChannel { get; set; }

    /// <summary>
    ///     Extension called
    /// </summary>
    public string? CallerId { get; set; }

    /// <summary>
    ///     BlfStatusType
    /// </summary>
    [UbluxValidationRequired]
    public BlfStatusType BlfStatusType { get; set; }

    /// <summary>
    ///     Is incoming or outgoing channel. If receiving phone call it is incoming. If it is making call it is outgoing.
    ///     In other words it if true it means it goes from asterisk to phone
    ///     If false it means it goes from phone to asterisk
    /// </summary>
    public required bool IsIncoming { get; set; }

    /// <summary>
    ///     With what ip phone is connected. Empty string if PSTN
    /// </summary>
    public string? IdPhoneConnectedWith { get; set; }
}
