namespace Ublux.Communications.Models;

/// <summary>
///     Call is attended transferred to extension
/// </summary>
public class ChildCallAttendantTransferToExtension : ChildCall, IAttendantTransfer
{
    /// <summary>
    ///     Extension to whom it was transferred
    /// </summary>
    [References(typeof(Extension))]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     AttendantTransferToExtension
    /// </summary>
    [UbluxValidationIsRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.AttendantTransferToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary> Id of call that attendant transfered this call </summary>
    [References(typeof(Call))]
    public required string IdCallAttendantTransfer { get; set; }
}
