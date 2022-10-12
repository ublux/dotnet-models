﻿namespace Ublux.Communications.Models;

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
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.BlindTransferToPSTN;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}
