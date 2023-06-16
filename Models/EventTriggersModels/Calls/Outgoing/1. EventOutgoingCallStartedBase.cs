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
    public required string PhoneThatInitiatedCallId { get; set; }

    /// <summary>
    ///     Friendly name of line that initiated phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string PhoneThatInitiatedCallFrienlyName { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    protected new T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventOutgoingCallStartedBase
    {
#warning fix this
        throw new NotImplementedException();

        //var obj = base.GetRandomBase<T>(instance);
        
        //GenerateRandomIdAccountPhoneAndPhone(instance, out _, out _, out var idPhone);
        //obj.PhoneThatInitiatedCallId = idPhone;
        //obj.PhoneThatInitiatedCallFrienlyName = Constants.RandomNames[Random.Shared.Next(0, Constants.RandomNames.Length)];

        //return obj;
    }
}