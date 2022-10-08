#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group used to call multiple parties
/// </summary>
public partial class PowerDialerGroup : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public required string IdAccount { get; set; }

    #endregion

}

#endif