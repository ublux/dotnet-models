namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone number (VoipNumber)
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(VoipNumberType))]
[JsonSubtypes.KnownSubType(typeof(VoipNumberAvailableForPurchase), nameof(VoipNumberType.AvailableForPurchase))]
[JsonSubtypes.KnownSubType(typeof(VoipNumberFax), nameof(VoipNumberType.Fax))]
[JsonSubtypes.KnownSubType(typeof(VoipNumberPhone), nameof(VoipNumberType.Phone))]
[BsonKnownTypes(
    typeof(VoipNumberAvailableForPurchase),
    typeof(VoipNumberFax),
    typeof(VoipNumberPhone)
)]
public abstract partial class VoipNumber : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References    

    /// <summary>
    ///     Music on hold to use for outgoing calls to PSTN only
    /// </summary>
    [References(typeof(MusicOnHoldGroup))]
    [AllowUpdate(true)]
    public string? IdMusicOnHoldGroup { get; set; } 

    #endregion

    #region abstract

    /// <summary>
    ///     key = id of logic OR id of extension.  
    ///     value = day of week when it executes
    /// </summary>   
    [AllowUpdate(true)] 
    public abstract List<RulePhone> RulesPhone { get; set; }

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
    [AllowUpdate(true)]
    public abstract List<RuleSms> RulesSms { get; set; }

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
    [AllowUpdate(true)] 
    public abstract List<RuleFax> RulesFax { get; set; }

    #endregion

    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public abstract VoipNumberType VoipNumberType
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    }

    /// <summary>
    ///     This is only for external incoming calls
    ///     If the friendly name of this VoipNumber is "Spanish Support" then "Spanish Support" 
    ///     will be injected to the caller id allowing the agent to know that she has to answer in Spanish for example
    /// </summary>
    [AllowUpdate(true)]
    public bool InjectFriendlyNameToCallerId { get; set; }

    /// <summary>
    ///     Record incoming phone calls received by this phone number?
    /// </summary>
    [AllowUpdate(true)]
    public bool RecordIncomingCalls { get; set; }

    /// <summary>
    ///     Users will be charged extra for AI transcriptions. If this is true call will be recorded in order to do AI work
    /// </summary>
    [AllowUpdate(true)]
    public bool UseAiForIncomingCalls { get; set; }

    /// <summary>
    ///     Phone number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string Number { get; set; } = string.Empty;

    /// <summary>
    ///     Incoming phone number friendly name
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationIsRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Incoming phone number description
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(1000)]
    public string? Description { get; set; }

    /// <summary>
    ///     Example: EN, SP, etc..
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationIsRequired]
    public required Language Language { get; set; }

    /// <summary>
    ///     City of incoming phone number
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]    
    public required string City { get; set; } = string.Empty;

    /// <summary>
    ///     State of incoming phone number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string State { get; set; } = string.Empty;

    /// <summary>
    ///     Country of incoming phone number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     Does this phone number have SMS capabilities?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required bool IsSmsEnabled { get; set; }

    /// <summary>
    ///     Does this phone number have calling capabilities?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required bool IsVoiceEnabled { get; set; }

    /// <summary>
    ///     Is this phone number toll free?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required bool IsTollFree { get; set; }

    ///// <summary>
    /////     Does this number support WhatsApp?
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[IsUbluxRequired]
    //public required bool IsWhatsappEnabled { get; set; }

    /// <summary>
    ///     TimeZone of this phone number
    /// </summary>
    [AllowUpdate(true)]
    public string TimeZone { get; set; } = "America/New_York";

    #endregion

    #region Helper methods

    /// <summary>
    ///     This is important to look up for phone numbers because sometimes they are stored with country ISO codes and sometimes they are not.
    /// </summary>
    public static string GetLast8DigitsOfPhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber))
            return "";

        var phoneNumberWithoutIllegalChars = new string(phoneNumber.Where(char.IsDigit).ToArray());
        return phoneNumberWithoutIllegalChars[Math.Max(0, phoneNumberWithoutIllegalChars.Length - 8)..];
    }

    #endregion


    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by number
        yield return new MongoDbIndex(collection, nameof(this.Number))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
        
    }

    #endregion
}
