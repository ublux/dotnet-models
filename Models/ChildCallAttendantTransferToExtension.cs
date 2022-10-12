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
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.AttendantTransferToExtension;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }


    /// <summary> Id of call that attendant transfered this call </summary>

    public required string IdCallAttendantTransfer { get; set; }
}
