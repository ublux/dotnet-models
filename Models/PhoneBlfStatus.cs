namespace Ublux.Communications.Models;

/// <summary>
///     BLF status of a line
/// </summary>
public class PhoneBlfStatus
{
    /// <summary>
    ///     Id of line
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
}
