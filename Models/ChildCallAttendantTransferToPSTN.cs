namespace Ublux.Communications.Models;

/// <summary>
///     Call is attended transferred to land-line or cell-phone
/// </summary>
public class ChildCallAttendantTransferToPSTN : ChildCall, IAttendantTransfer
{
    /// <summary>
    ///     Phone number where call was transferred to
    /// </summary>
    [UbluxValidationIsRequired]
    public required string PhoneNumber { get; set; }

    /// <summary>
    ///     AttendantTransferToPSTN
    /// </summary>
    [UbluxValidationIsRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.AttendantTransferToPSTN;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary> Id of call that attendant transfered this call </summary>
    [References(typeof(Call))]
    public required string IdCallAttendantTransfer { get; set; }

    /// <summary>
    ///     Id of contact to whom call is being transfered
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Contact))]
    public string? IdContact { get; set; }

    /// <summary>
    ///     Contact full name    
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactFullName { get; set; }
}
