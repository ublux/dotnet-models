namespace Ublux.Communications.Models;

/// <summary>
///     Call is attended transferred to land-line or cell-phone
/// </summary>
public class ChildCallAttendantTransferToPSTN : ChildCall, IAttendantTransfer
{
    /// <summary>
    ///     Phone number where call was transferred to
    /// </summary>
    [IsUbluxRequired]
    public required string PhoneNumber { get; set; }

    /// <summary>
    ///     AttendantTransferToPSTN
    /// </summary>
    [IsUbluxRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.AttendantTransferToPSTN;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <summary> Id of call that attendant transfered this call </summary>
    [References(typeof(Call))]
    public required string IdCallAttendantTransfer { get; set; }
}
