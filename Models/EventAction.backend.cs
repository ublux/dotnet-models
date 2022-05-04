#if UBLUX_BACKEND
namespace Ublux.Communications.Models;

/// <summary>
///     EventAction to execute if a specific event occurs. 
///     For example if an extension is not answered send an email notification
/// </summary>
[BsonKnownTypes(
    typeof(EventActionForwardToExtension),
    typeof(EventActionForwardToPhoneNumber),
    typeof(EventActionLeaveVoicemail)
)]
public abstract partial class EventAction
{
}
#endif
