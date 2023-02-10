﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class AiCallTranscription : UbluxDocument, IReferencesTags, IReferncesAccount
{
    #region References

    /// <summary>
    ///     Account that uses this caller id mask
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;

    #endregion
}