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
public abstract partial class VoipNumber : UbluxDocument
{
    #region Properties

    #region abstract

    /// <summary>
    ///     key = id of logic OR id of extension.  
    ///     value = day of week when it executes
    /// </summary>   
    [AllowUpdate(false)]
    public abstract List<RulePhone> RulesPhone { get; set; }

    /// <summary>
    ///     Incoming SMS will be sent to these email addresses
    /// </summary>
    [AllowUpdate(false)]
    public abstract List<RuleSms> RulesSms { get; set; }

    /// <summary>
    ///     Incoming Faxes will be sent to this email addresses
    /// </summary>
    [AllowUpdate(false)]
    public abstract List<RuleFax> RulesFax { get; set; }

    #endregion

    /// <summary>
    ///     Type of VOIP number
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public abstract VoipNumberType VoipNumberType { get; }

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
    ///     Phone number
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string Number { get; set; }

    /// <summary>
    ///     Incoming phone number friendly name
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Incoming phone number description
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    /// <summary>
    ///     Example: EN, SP, etc..
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required Language Language { get; set; }

    /// <summary>
    ///     City of incoming phone number
    /// </summary>    
    [AllowUpdate(false)]
    [IsRequired]
    public required string City { get; set; }

    /// <summary>
    ///     State of incoming phone number
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string State { get; set; }

    /// <summary>
    ///     Country of incoming phone number
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     Does this phone number have SMS capabilities?
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required bool IsSmsEnabled { get; set; }

    /// <summary>
    ///     Does this phone number have calling capabilities?
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required bool IsVoiceEnabled { get; set; }

    /// <summary>
    ///     Is this phone number toll free?
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required bool IsTollFree { get; set; }

    /// <summary>
    ///     Does this number support WhatsApp?
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required bool IsWhatsappEnabled { get; set; }

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
}
