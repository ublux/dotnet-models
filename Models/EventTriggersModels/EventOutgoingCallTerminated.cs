﻿using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

public partial class EventOutgoingCallTerminated
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
    public DateTime? DateAnswer { get; set; }

    /// <summary>
    ///     Date when call was ended
    /// </summary>
    [AllowUpdate(false)]
    public DateTime DateEnded { get; set; }

    /// <summary>
    ///     Id of contact to whom call was made
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
    public override EventOutgoingCallTerminated BuildRandomFakeObject()
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var randChannel = Random.Shared.Next(100000, 999999);
        var randomId = CallOutgoingToPSTN.BuildId(randInstanceId, $"{randChannel}.0").Id;
        var randomIdContact = Contact.BuildId(randInstanceId).Id;

        var f = new Faker<EventOutgoingCallTerminated>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.IdContact, randomIdContact)
            .RuleFor(x => x.ContactFullName, x=>x.Name.FullName())
            ;

        EventOutgoingCallTerminated obj = f.Generate();
        
        // set dates
        obj.DateStart = DateTime.UtcNow.AddHours(-1);
        obj.DateAnswer = obj.DateStart.AddSeconds(10);
        obj.DateEnded = obj.DateAnswer.Value.AddSeconds(Random.Shared.Next(10, 3600));

        return obj;
    }
}
