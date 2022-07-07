namespace Ublux.Communications.Models;

/// <summary>
///     Call is blind transferred to land-line or cell-phone
/// </summary>
public class ChildCallBlindTransferToPSTN : ChildCallBlindTransfer
{
    /// <summary>
    ///     Phone number where call was transferred to
    /// </summary>
    public required string PhoneNumber { get; set; }

    /// <summary>
    ///     Trunk used to make call
    /// </summary>
    public string? IdTrunkTermination { get; set; }

    /// <summary>
    ///     BlindTransferToPSTN
    /// </summary>
    [IsRequired]
    public override ChildCallType ChildCallType { get; } = ChildCallType.BlindTransferToPSTN;
}
