namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Base class for incoming calls
/// </summary>
public abstract class EventIncomingCallStartedBase : EventCallStartedBase
{
    /// <summary>
    ///     Return a random object
    /// </summary>
    protected new T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventIncomingCallStartedBase
    {
        return base.GetRandomBase<T>(instance);
    }
}
