﻿namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Base class for when an outgoing call ends
/// </summary>
public abstract class EventOutgoingCallEndedBase : EventOutgoingCallStartedBase
{
    /// <summary>
    ///     Date when call was answered
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? SecondsItTookToAnswer { get; set; }

    /// <summary>
    ///     Id of line that answered in case it is an outgoing call to an extension
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? PhoneThatAnsweredId { get; set; }

    /// <summary>
    ///     Friendly name of line that answered in case it is an outgoing call to an extension
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? PhoneThatAnsweredFrienlyName { get; set; }

    /// <summary>
    ///     How long call lasted in seconds
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required double DurationInSeconds { get; set; }

    /// <summary>
    ///     Times when call was placed on hold
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required List<TimeWhenCallPlacedOnHold> TimesWhenCallPlacedOnHold { get; set; } = [];

    /// <summary>
    ///     Return a random object
    /// </summary>
    public new T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventOutgoingCallEndedBase
    {
        var obj = base.GetRandomBase<T>(instance);

        // generate random id of line
        var idAccount = Account.BuildId(Random.Shared.Next(10, 1000).ToString()).Id;
        var idPhone = Phone.BuildId(instance, idAccount).Id;

        obj.SecondsItTookToAnswer = Random.Shared.Next(2, 10);
        obj.PhoneThatAnsweredId = idPhone;
        obj.PhoneThatAnsweredFrienlyName = Constants.RandomNames[Random.Shared.Next(0, Constants.RandomNames.Length)];
        obj.DurationInSeconds = Random.Shared.Next(60, 600);

        // Time when call was placed on hold
        var timeWhenPlacedOnHold = Random.Shared.Next(10, ((int)obj.DurationInSeconds) - 5);
        obj.TimesWhenCallPlacedOnHold.Add(new TimeWhenCallPlacedOnHold
        {
            SecondsElapsedWhenPlacedOnHold = timeWhenPlacedOnHold + 0.1,
            SecondsElapsedWhenRemovedFromHold = timeWhenPlacedOnHold + 5
        });

        return obj;
    }
}
