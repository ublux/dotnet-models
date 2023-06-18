namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Base class for incoming calls that ended
/// </summary>
public abstract class EventIncomingCallEndedBase : EventIncomingCallStartedBase
{
    /// <summary>
    ///     Date when call was answered
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? SecondsItTookToAnswer { get; set; }

    /// <summary>
    ///     Id of line that answered
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? PhoneThatAnsweredId { get; set; }

    /// <summary>
    ///     Friendly name of line that answered
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? PhoneThatAnsweredFrienlyName { get; set; }

    /// <summary>
    ///     Date when call was ended
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required double DurationInSeconds { get; set; }

    /// <summary>
    ///     Times when call was placed on hold
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required List<TimeWhenCallPlacedOnHold> TimesWhenCallPlacedOnHold { get; set; } = new();

    /// <summary>
    ///     Return a random object
    /// </summary>
    protected new T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventIncomingCallEndedBase
    {
        var obj = base.GetRandomBase<T>(instance);
        obj.SecondsItTookToAnswer = Random.Shared.Next(2, 10);
        var idAccount = Account.BuildId(Random.Shared.Next(10, 1000).ToString()).Id;
        var idPhone = Phone.BuildId(instance, idAccount).Id;
        obj.PhoneThatAnsweredId = idPhone;
        obj.PhoneThatAnsweredFrienlyName = Constants.RandomNames[Random.Shared.Next(0, Constants.RandomNames.Length)];
        obj.DurationInSeconds = Random.Shared.Next(60, 600);

        // Time when call was placed on hold
        var timeWhenPlacedOnHold = Random.Shared.Next(10, ((int)obj.DurationInSeconds) - 5);
        obj.TimesWhenCallPlacedOnHold.Add(new TimeWhenCallPlacedOnHold()
        {
            SecondsElapsedWhenPlacedOnHold = timeWhenPlacedOnHold + 0.1,
            SecondsElapsedWhenRemovedFromHold = timeWhenPlacedOnHold + 5
        });

        return obj;
    }
}
