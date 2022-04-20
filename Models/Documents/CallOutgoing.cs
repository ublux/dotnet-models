﻿namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Outgoing phone call
/// </summary>
public abstract class CallOutgoing : Call
{
    /// <summary>    
    ///     Contact to whom we are calling
    /// </summary>
    [AllowUpdate(false)]
        public override Contact? Contact { get; set; }

    /// <summary>
    ///     Id line that started phone call
    /// </summary>
    [AllowUpdate(false)]
        [References(typeof(Line))]
    [Required]
    public string IdLineThatInitiatedCall { get; set; } = string.Empty;
}
































