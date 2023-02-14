#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     VOIP provider. Some providers have an API that enable us to automate things.
///     Examples of voip providers are Twilio, Marcatel, Airnetworks etc...
/// </summary>
public partial class VoipProvider : UbluxDocument
{
    /// <summary>
    ///     Id on provider. We may need this to authenticate
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required string ProviderAccountId { get; set; } = string.Empty;

    /// <summary>
    ///     The account id of the owner account. If this is the owner account then this will be the same as the id
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public string? ProviderOwnerAccountId { get; set; }

    /// <summary>
    ///     Twilio calls this authority token
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public string? ProviderAccessToken { get; set; }

    /// <summary>
    ///     Ublux partner
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required UbluxPartner UbluxPartner { get; set; } 

    /// <summary>
    ///     Friendly name of this provider
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Used mostly for sub-accounts. A sub account in twilio can be suspended, closed or active 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public string? Status { get; set; }

    /// <summary>
    ///     Country of this provider
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Company of this provider for example Twilio
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required VoipCompany VoipCompany { get; set; }
}

#endif