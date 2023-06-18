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

        var obj = base.GetRandomBase<T>(instance);

        var idAccount = Account.BuildId(Random.Shared.Next(10, 1000).ToString()).Id;
        var idPhone = Phone.BuildId(instance, idAccount).Id;
        obj.PhoneThatInitiatedCallId = idPhone;
        obj.PhoneThatInitiatedCallFrienlyName = Constants.RandomNames[Random.Shared.Next(0, Constants.RandomNames.Length)];

        return obj;
    }
}