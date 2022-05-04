#if UBLUX_BACKEND
namespace Ublux.Communications.Models.Documents; 

/// <summary>
///     VOIP provider. Some providers have an API that enable us to automate things.
/// </summary>
public partial class VoipProvider : UbluxDocument
{
    /// <summary>
    ///     Id on provider. We may need this to authenticate
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public string SID { get; set; } = string.Empty;

    /// <summary>
    ///     Ublux partner
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public UbluxPartner UbluxPartner { get; set; }

    /// <summary>
    ///     Twilio calls this authority token
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? AccessToken { get; set; }

    /// <summary>
    ///     Friendly name of this provider
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Used mostly for sub-accounts. A sub account in twilio can be suspended, closed or active 
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? Status { get; set; }

    /// <summary>
    ///     The account id of the owner account. If this is the owner account then this will be the same as the id
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? OwnerAccountId { get; set; }

    /// <summary>
    ///     Country of this provider
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Company of this provider for example Twilio
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public VoipCompany VoipCompany { get; set; }
}
#endif