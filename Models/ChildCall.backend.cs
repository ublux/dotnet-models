#if UBLUX_BACKEND
namespace Ublux.Communications.Models;
/// <summary>
///     This attributes are needed so that deserialization works.
/// </summary>
[BsonKnownTypes(
    typeof(ChildCallForwardToExtension),
    typeof(ChildCallAttendantTransferToExtension),
    typeof(ChildCallAttendantTransferToPSTN),
    typeof(ChildCallBlindTransferToExtension),
    typeof(ChildCallBlindTransferToPSTN)
)]
public abstract partial class ChildCall
{   
}
#endif