﻿#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

public partial class Voicemail : IReferncesAccount
{
    #region References

    /// <inheritdoc />
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? IdAccount { get; set; }

    #endregion
}

#endif