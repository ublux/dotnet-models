﻿using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

public partial class EventExtensionNotAnswered
{
    /// <summary>
    ///     Extension friendly name
    /// </summary>
    [AllowUpdate(false)]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Extension number
    /// </summary>
    [AllowUpdate(false)]
    public required string Number { get; set; }

    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)]
    public required string From { get; set; }

    /// <summary>
    ///     To phone number
    /// </summary>
    [AllowUpdate(false)]
    public required string To { get; set; }

    /// <summary>
    ///     Date when call started
    /// </summary>
    [AllowUpdate(false)]
    public DateTime DateStart { get; set; }       

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
    ///     How long extension rang
    /// </summary>
    [AllowUpdate(false)]
    public int NumberOfSecondsItRang { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventExtensionNotAnswered BuildRandomFakeObject()
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var randomId = ExtensionDial.BuildId(randInstanceId).Id;
        var randomIdContact = Contact.BuildId(randInstanceId).Id;

        var f = new Faker<EventExtensionNotAnswered>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.IdContact, randomIdContact)
            .RuleFor(x => x.ContactFullName, x=>x.Name.FullName())
            .RuleFor(x => x.FriendlyName, x=>x.Name.FullName())
            ;

        EventExtensionNotAnswered obj = f.Generate();

        obj.Number = Random.Shared.Next(10, 1000).ToString();
        obj.NumberOfSecondsItRang = Random.Shared.Next(0, 60);

        // set dates
        obj.DateStart = DateTime.UtcNow.AddHours(-1);

        return obj;
    }
}