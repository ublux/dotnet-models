﻿using System.Collections.Concurrent;

namespace Ublux.Communications.Models;

/// <summary>
///     Call is blind transferred to an extension
/// </summary>
public class ChildCallBlindTransferToExtension : ChildCallBlindTransfer, ICallToExtension
{
    /// <summary>
    ///     Extension where it was blind transferred to
    /// </summary>
    [References(typeof(Extension))]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     BlindTransferToExtension
    /// </summary>
    [UbluxValidationRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.BlindTransferToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Id of line that answered
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Phone))]
    public string? IdPhoneThatAnswered { get; set; }

    /// <summary>
    ///     Ids of lines that ring
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Phone))]
    public ConcurrentBag<string> IdsPhonesThatRing { get; set; } = [];

    /// <summary>
    ///     Ids of lines that where supposed to ring and did not ring because phone was offline or disconnected.
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Phone))]
    public ConcurrentBag<string> IdsPhonesThatDidNotRing { get; set; } = [];
}
