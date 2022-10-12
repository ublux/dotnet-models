#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents; 

/// <summary>
///     SMS message
/// </summary>
public partial class SMS : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(Account))]
    [IsUbluxRequired]
    public required string IdAccount { get; set; }    

    #endregion
}

#endif