namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Base class for outgoing calls events
/// </summary>
public abstract class EventOutgoingCallStartedBase : EventCallBase
{
    /// <summary>
    ///     Id of line that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string LineThatInitiatedCallId { get; set; }

    /// <summary>
    ///     Friendly name of line that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string LineThatInitiatedCallFrienlyName { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    protected new T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventOutgoingCallStartedBase
    {
        var obj = base.GetRandomBase<T>(instance);
        
        GenerateRandomIdAccountPhoneAndLine(instance, out _, out _, out var idLine);
        obj.LineThatInitiatedCallId = idLine;
        obj.LineThatInitiatedCallFrienlyName = Constants.RandomNames[Random.Shared.Next(0, Constants.RandomNames.Length)];

        return obj;
    }
}