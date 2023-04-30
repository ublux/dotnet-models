using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventIncomingCallStarted"/>
/// </summary>
public partial class EventIncomingCallStarted
{
    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string From { get; set; }

    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string To { get; set; }

    /// <summary>
    ///     Date when call started
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public DateTime DateStart { get; set; }

    /// <summary>
    ///     Id of contact that made phone call
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? IdContact { get; set; }    

    /// <summary>
    ///     Name of contact
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? ContactFullName { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallStarted BuildRandomFakeObject()
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var randChannel = Random.Shared.Next(100000, 999999);
        var randomId = CallIncomingToExtension.BuildId(randInstanceId, $"{randChannel}.0").Id;
        var randomIdContact = Contact.BuildId(randInstanceId).Id;

        var f = new Faker<EventIncomingCallStarted>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.IdContact, randomIdContact)
            .RuleFor(x => x.ContactFullName, x=>x.Name.FullName())
            ;

        EventIncomingCallStarted obj = f.Generate();
        
        // set dates
        obj.DateStart = DateTime.UtcNow.AddHours(-1);

        return obj;
    }
}
