﻿namespace Ublux.Communications.Models;

/// <summary>
///     Power dialer that executes an IVR
/// </summary>
public class PowerDialerAdvance : PowerDialer
{
    /// <summary>
    ///     IVR to execute
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(true)]
    public required string IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Type of power dialer
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override PowerDialerType PowerDialerType
    {
        get => PowerDialerType.Advanced;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}
