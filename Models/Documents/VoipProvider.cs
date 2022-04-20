namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
    [Required]
    public string SID { get; set; } = string.Empty;

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
    [Required]
    public string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Used mostly for sub-accounts. A sub account in twilio can be suspended, closed or active 
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? Status { get; set; }

    /// <summary>
    ///     The account id of the owner account. If this is the owner account then this will be the same as the _id
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? OwnerAccountId { get; set; }

    /// <summary>
    ///     Country of this provider
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Company of this provider for example Twilio
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public VoipCompany VoipCompany { get; set; }

    /// <summary>
    ///     Ublux partner
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public UbluxPartner UbluxPartner { get; set; }

    ///// <inheritdoc/>
    //public override VoipProvider To()
    //{
    //    return new VoipProviderDTO()
    //    {
    //        DateUpdated = this.DateUpdated.FromUnixEpoch(),
    //        DateCreated = this.DateCreated.FromUnixEpoch(),
    //        Id = this._id
    //    };
    //}

}
