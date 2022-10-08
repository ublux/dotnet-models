﻿namespace Ublux.Communications.Models;

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
    public override ChildCallType ChildCallType { get; } = ChildCallType.BlindTransferToExtension;
}
