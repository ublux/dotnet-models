#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public partial class WebHook : UbluxDocument, IReferncesAccount
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