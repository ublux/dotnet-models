﻿#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of faxes sent as a group via email
/// </summary>
public partial class FaxOutgoingGroup : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;
}

#endif