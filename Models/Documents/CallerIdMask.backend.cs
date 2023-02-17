﻿#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class CallerIdMask 
{    
    /// <summary>
    ///     Code that user must enter to verify caller id
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string RandomVerificationCode { get; set; } = string.Empty;

}

#endif