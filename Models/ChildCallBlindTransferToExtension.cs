namespace Ublux.Communications.Models;

/// <summary>
///     Call is blind transferred to an extension
/// </summary>
public class ChildCallBlindTransferToExtension : ChildCallBlindTransfer
{
    /// <summary>
    ///     Extension where it was blind transferred to
    /// </summary>
    //[IsUbluxRequired]
    public Extension? Extension { get; set; }

    /// <summary>
    ///     BlindTransferToExtension
    /// </summary>
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.BlindTransferToExtension;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}
