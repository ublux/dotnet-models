#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

public partial class Voicemail : IReferncesAccount
{
    #region References

    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(Account))]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;

    #endregion
}

#endif