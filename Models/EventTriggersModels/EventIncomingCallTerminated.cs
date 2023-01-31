﻿using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventIncomingCallTerminated"/>
/// </summary>
public partial class EventIncomingCallTerminated
{
    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)]
    public required string From { get; set; }

    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)]
    public required string To { get; set; }

    /// <summary>
    ///     Date when call started
    /// </summary>
    [AllowUpdate(false)]
    public DateTime DateStart { get; set; }

    /// <summary>
    ///     Date when call was answered
    /// </summary>
    [AllowUpdate(false)]
    public int? SecondsItTookToAnswer { get; set; }

    /// <summary>
    ///     Date when call was ended
    /// </summary>
    [AllowUpdate(false)]
    public DateTime DateEnded { get; set; }

    /// <summary>
    ///     Id of contact that made phone call
    /// </summary>
    [AllowUpdate(false)]
    public string? IdContact { get; set; }

    /// <summary>
    ///     Name of contact
    /// </summary>
    [AllowUpdate(false)]
    public string? ContactFullName { get; set; } 

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallTerminated BuildRandomFakeObject()
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var randChannel = Random.Shared.Next(100000, 999999);
        var randomId = CallIncomingToExtension.BuildId(randInstanceId, $"{randChannel}.0").Id;
        var randomIdContact = Contact.BuildId(randInstanceId).Id;

        var f = new Faker<EventIncomingCallTerminated>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.IdContact, randomIdContact)
            .RuleFor(x => x.ContactFullName, x=>x.Name.FullName())
            ;

        EventIncomingCallTerminated obj = f.Generate();
        
        // set dates
        obj.DateStart = DateTime.UtcNow.AddHours(-1);
        obj.SecondsItTookToAnswer = 10;
        obj.DateEnded = obj.DateStart.AddSeconds(Random.Shared.Next(20, 3600));

        return obj;
    }
}
