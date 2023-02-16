#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Needed because some providers like the one from Spain require customers info in order to purchase VoipNumber
/// </summary>
public partial class CustomerInfo : IReferncesAccount
{
    #region References

    /// <inheritdoc/>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? IdAccount { get; set; }

    #endregion
}

#endif