using Bogus;

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
    ///     Date when call was answered
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public double? SecondsItTookToAnswer { get; set; }

    /// <summary>
    ///     Date when call was ended
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public double DurationInSeconds { get; set; }

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
    ///     Times when call was placed on hold
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<TimeWhenCallPlacedOnHold> TimesWhenCallPlacedOnHold { get; set; } = new List<TimeWhenCallPlacedOnHold>();

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventIncomingCallTerminated BuildRandomFakeObject(RunningApplicationInstance instance)
    {        
        var randChannel = Random.Shared.Next(100000, 999999);
        var randomId = CallIncomingToExtension.BuildId(instance, $"{randChannel}.0").Id;
        var randomIdContact = Contact.BuildId(instance).Id;

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
        obj.DurationInSeconds = Random.Shared.Next(20, 3600);
        var timeWhenPlacedOnHold = Random.Shared.Next(10, ((int)obj.DurationInSeconds) - 5);
        obj.TimesWhenCallPlacedOnHold.Add(new TimeWhenCallPlacedOnHold()
        {
            SecondsElapsedWhenPlacedOnHold = timeWhenPlacedOnHold + 0.1,
            SecondsElapsedWhenRemovedFromHold = timeWhenPlacedOnHold + 5
        });

        return obj;
    }
}
