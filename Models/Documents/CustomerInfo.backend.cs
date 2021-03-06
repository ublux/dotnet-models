#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Needed because some providers like the one from Spain require customers info in order to purchase VoipNumber
/// </summary>
public partial class CustomerInfo : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdAccount { get; set; }

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Address where this phone number is intended to be used
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required MailingAddress MailingAddress { get; set; }

    /// <summary>
    ///     If its a VoipNumber from provider AirNetworks then this information is required
    /// </summary>
    [AllowUpdate(false)]
    public AirNetworksCustomerInfo? AirNetworksCustomerInfo { get; set; }

    #endregion

    /// <summary>
    ///     Full legal name
    /// </summary>
    [AllowUpdate(true)]
    public required string FullName { get; set; }

    #endregion
}

#endif