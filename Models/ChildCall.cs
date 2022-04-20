using JsonSubTypes;

namespace Ublux.Communications.Models;

/// <summary>
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(ChildCallType))]
[JsonSubtypes.KnownSubType(typeof(ChildCallForwardToExtension), nameof(ChildCallType.ForwardToExtension))]
[JsonSubtypes.KnownSubType(typeof(ChildCallAttendantTransferToExtension),
    nameof(ChildCallType.AttendantTransferToExtension))]
[JsonSubtypes.KnownSubType(typeof(ChildCallAttendantTransferToPSTN), nameof(ChildCallType.AttendantTransferToPSTN))]
[JsonSubtypes.KnownSubType(typeof(ChildCallBlindTransferToExtension), nameof(ChildCallType.BlindTransferToExtension))]
[JsonSubtypes.KnownSubType(typeof(ChildCallBlindTransferToPSTN), nameof(ChildCallType.BlindTransferToPSTN))]
[BsonKnownTypes(
    typeof(ChildCallForwardToExtension),
    typeof(ChildCallAttendantTransferToExtension),
    typeof(ChildCallAttendantTransferToPSTN),
    typeof(ChildCallBlindTransferToExtension),
    typeof(ChildCallBlindTransferToPSTN)
)]
[BsonIgnoreExtraElements]
public abstract class ChildCall
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
    [Required]
    public abstract ChildCallType ChildCallType { get; }

    ///// <summary>
    /////     True if transferred from channel that is not being executed on dialplan. 
    ///// </summary>
    //public bool IsSwaped { get; set; }
}