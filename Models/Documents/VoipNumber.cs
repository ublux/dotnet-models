﻿namespace Ublux.Communications.Models.Documents;

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
    [UbluxValidationRequired]
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
    ///     Record, transcribe or AI analyse call. 
    ///     This is only for incoming calls made to this number.
    ///     Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.    
    /// </summary>
    [AllowUpdate(true)]
    public CallProcessingType ProcessingType { get; set; }

    /// <summary>
    ///     What input to pass to AI engine in case UseAiForIncomingCalls=true. If null it should use a default input that is part of constants.
    ///     For this to work ProcessingType should equal AiAnalyze
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(AiCallAnalysisInput))]
    public string? IdAiCallAnalysisInput { get; set; }

    /// <summary>
    ///     Phone number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(9, 14)]
    public required string Number { get; set; } = string.Empty;

    /// <summary>
    ///     Incoming phone number friendly name
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
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
    [UbluxValidationRequired]
    public required Language Language { get; set; }

    /// <summary>
    ///     City of incoming phone number
    /// </summary>    
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string City { get; set; } = string.Empty;

    /// <summary>
    ///     State of incoming phone number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string State { get; set; } = string.Empty;

    /// <summary>
    ///     Country of incoming phone number
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     Does this phone number have SMS capabilities?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required bool IsSmsEnabled { get; set; }

    /// <summary>
    ///     Does this phone number have calling capabilities?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required bool IsVoiceEnabled { get; set; }

    /// <summary>
    ///     Is this phone number toll free?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
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
    [UbluxValidationRequired]
    public required string TimeZone { get; set; } = "America/New_York";

    /// <summary>
    ///     Beause a lot of collections depend on a number instead of deleting it we mark it as disconnected.
    /// </summary>
    [SwaggerSchema(ReadOnly = true)]
    [AllowUpdate(false)]
    public bool IsDisconnected { get; set; }

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


    /// <summary>
    ///     Returns id of voip number in case idVoipNumberOrPhoneNumber is not an ID
    ///     GetManyOptions? options = null, IEnumerable? projectionPropToInclude = null, ushort timeout = 7, bool searchOnDeletedItems = false
    /// </summary>
    public static string? FindIdGivenPhoneNumber(string idVoipNumberOrPhoneNumber, IEnumerable<VoipNumber>? allVoipNumbersFromAccountWhereToSearchFrom)
    {
        if (idVoipNumberOrPhoneNumber.Contains(RedisConstants.DelimiterId))
        {
            // it should be an id
            return idVoipNumberOrPhoneNumber;
        }

        if (allVoipNumbersFromAccountWhereToSearchFrom is null)
            return null;

        // if its a phone number build id
        var last8Digits = GetLast8DigitsOfPhoneNumber(idVoipNumberOrPhoneNumber);
        var vn = allVoipNumbersFromAccountWhereToSearchFrom.FirstOrDefault(x => x.Id.Contains(last8Digits));
        if (vn is not null)
            return vn.id;

        return null;
    }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by number
        yield return new MongoDbIndex(collection, nameof(Number))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

    }

    #endregion
}
