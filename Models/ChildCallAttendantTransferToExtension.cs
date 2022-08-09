namespace Ublux.Communications.Models;

/// <summary>
///     Call is attended transferred to extension
/// </summary>
public class ChildCallAttendantTransferToExtension : ChildCall, IAttendantTransfer
{
    /// <summary>
    ///     Extension to whom it was transferred
    /// </summary>
    public Extension? Extension { get; set; } 

    /// <summary>
    ///     AttendantTransferToExtension
    /// </summary>
    [IsRequired]
    public override ChildCallType ChildCallType { get; } = ChildCallType.AttendantTransferToExtension;


    /// <summary> Id of call that attendant transfered this call </summary>

    public required string IdCallAttendantTransfer { get; set; }
}
