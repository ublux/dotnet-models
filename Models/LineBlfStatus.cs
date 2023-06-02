namespace Ublux.Communications.Models;

/// <summary>
///     BLF status of a line
/// </summary>
public class LineBlfStatus
{
    /// <summary>
    ///     Id of line
    /// </summary>
    [UbluxValidationRequired]
    [References(typeof(Line))]
    public required string IdLine { get; set; }

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
