namespace Ublux.Communications.Models;

/// <summary>
///     This attributes are needed so that deserialization works. Newtonsoft.Json deserializer must be used.
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(ChildCallType))]
[JsonSubtypes.KnownSubType(typeof(ChildCallForwardToExtension), nameof(ChildCallType.ForwardToExtension))]
[JsonSubtypes.KnownSubType(typeof(ChildCallAttendantTransferToExtension), nameof(ChildCallType.AttendantTransferToExtension))]
[JsonSubtypes.KnownSubType(typeof(ChildCallAttendantTransferToPSTN), nameof(ChildCallType.AttendantTransferToPSTN))]
[JsonSubtypes.KnownSubType(typeof(ChildCallBlindTransferToExtension), nameof(ChildCallType.BlindTransferToExtension))]
[JsonSubtypes.KnownSubType(typeof(ChildCallBlindTransferToPSTN), nameof(ChildCallType.BlindTransferToPSTN))]
[JsonSubtypes.KnownSubType(typeof(ChildCallForwardToPSTN), nameof(ChildCallType.ForwardToPSTN))]
[BsonKnownTypes(
    typeof(ChildCallForwardToExtension),
    typeof(ChildCallAttendantTransferToExtension),
    typeof(ChildCallAttendantTransferToPSTN),
    typeof(ChildCallBlindTransferToExtension),
    typeof(ChildCallBlindTransferToPSTN),
    typeof(ChildCallForwardToPSTN)
)]
public abstract partial class ChildCall : ICall
{
    ///// <summary>
    /////     If outgoing:
    /////         Contact that we are calling
    /////     If incoming:
    /////         Contact that called us        
    ///// </summary>
    //public Contact? Contact { get; set; }

    ///// <summary>
    /////     Call that blind transferred this call
    ///// </summary>
    //public string? IdBlindTransfer { get; set; }

    ///// <summary>
    /////     Call that attended transferred this call
    ///// </summary>
    //public string? IdAttendedTransfer { get; set; }

    ///// <summary>
    /////     True if this call was
    ///// </summary>
    //public bool IsForwarded { get; set; }    

    /// <summary>
    ///     PSTN or EXTEN
    /// </summary>
    [UbluxValidationRequired]
    public abstract ChildCallType ChildCallType
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
#endif
    }

    ///// <summary>
    /////     True if transferred from channel that is not being executed on dialplan. 
    ///// </summary>
    //public bool IsSwaped { get; set; }

    /// <summary>
    ///     Status of call
    /// </summary>
    [UbluxValidationStringRange(50)]
    public required string DialStatus { get; set; }

    /// <inheritdoc />
    public DateTime DateCreated { get; set; }
    ///// <inheritdoc />
    //public DateTime? DateEnded { get; set; }

    /// <summary>
    ///     Number of seconds it took to answer
    /// </summary>
    public double? SecondsItTookToAnswer { get; set; }



    /// <summary>
    ///     Caller id
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required CountryIsoCode FromCountry { get; set; }

    /// <summary>
    ///     Phone number called
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string To { get; set; } = string.Empty;

    /// <summary>
    ///     Country that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required CountryIsoCode ToCountry { get; set; }

    /// <summary>
    ///     Is this call international
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required bool IsInternational { get; set; }
}