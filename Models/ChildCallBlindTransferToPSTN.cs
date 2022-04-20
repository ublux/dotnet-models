namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Call is blind transferred to land-line or cell-phone
/// </summary>
[BsonIgnoreExtraElements]
public class ChildCallBlindTransferToPSTN : ChildCallBlindTransfer
{
    /// <summary>
    ///     Phone number where call was transferred to
    /// </summary>
    public string PhoneNumber { get; set; } = string.Empty;

    /// <summary>
    ///     Trunk used to make call
    /// </summary>
    public string? IdTrunkTermination { get; set; }

    /// <summary>
    ///     BlindTransferToPSTN
    /// </summary>
    [Required]
    public override ChildCallType ChildCallType { get; } = ChildCallType.BlindTransferToPSTN;
}
