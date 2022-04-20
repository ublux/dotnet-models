namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
    public string IdAccount { get; set; } = String.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Address where this phone number is intended to be used
    /// </summary>
        [AllowUpdate(true)]
    [IsRequired]
    public MailingAddress MailingAddress { get; set; } = new MailingAddress();

    /// <summary>
    ///     If its a VoipNumber from provider AirNetworks then this information is required
    /// </summary>
        [AllowUpdate(false)]
    public AirNetworksCustomerInfo? AirNetworksCustomerInfo { get; set; }

    #endregion

    ///// <summary>
    /////     Ublux Partner
    ///// </summary>
    //[AllowUpdate(false)]
    //[IgnoreDataMember]
    //public UbluxPartner UbluxPartner { get; set; }

    /// <summary>
    ///     Full legal name
    /// </summary>
        [AllowUpdate(true)]
    public string FullName { get; set; } = String.Empty;

    #endregion
}
