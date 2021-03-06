namespace Ublux.Communications.Models;

/// <summary>
///     Call is attended transferred to land-line or cell-phone
/// </summary>
public class ChildCallAttendantTransferToPSTN : ChildCall
{
    /// <summary>
    ///     Phone number where call was transferred to
    /// </summary>
    [IsRequired]
    public required string PhoneNumber { get; set; }

    /// <summary>
    ///     AttendantTransferToPSTN
    /// </summary>
    [IsRequired]
    public override ChildCallType ChildCallType { get; } = ChildCallType.AttendantTransferToPSTN;
}
