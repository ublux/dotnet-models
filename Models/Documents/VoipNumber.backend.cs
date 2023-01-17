#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone number (VoipNumber)
/// </summary>
public abstract partial class VoipNumber : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc/>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Information about customer. This may be required by some providers.
    /// </summary>
    [References(typeof(CustomerInfo))]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? IdCustomerInfo { get; set; }

    /// <summary>
    ///     Responsible for receiving phone calls. May be null because phone number may not be activated (AvailableForPurcahse)
    /// </summary>
    [References(typeof(TrunkOrigination))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? IdTrunkOrigination { get; set; }

    /// <summary>
    ///     To what provider this belongs. Thanks to the provider we can use its API.
    /// </summary>
    [References(typeof(VoipProvider))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string IdVoipProvider { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     The id that the provider has for this DID. For example PN7e1d91934f11a9444f47c2de2cd354fa for a Twilio phone number
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string ProviderId { get; set; } = string.Empty;
}
#endif