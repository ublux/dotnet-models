using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventExtensionTookLongerThan2MinToBeAnswered"/>
/// </summary>
public partial class EventExtensionTookLongerThan2MinToBeAnswered
{
    /// <summary>
    ///     Extension friendly name
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Extension number
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string Number { get; set; }

    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required string From { get; set; }

    /// <summary>
    ///     To phone number
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
    ///     How long extension rang
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public double NumberOfSecondsItRang { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventExtensionTookLongerThan2MinToBeAnswered BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var randomId = ExtensionQueue.BuildId(instance).Id;
        var randomIdContact = Contact.BuildId(instance).Id;

        var f = new Faker<EventExtensionTookLongerThan2MinToBeAnswered>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.IdContact, randomIdContact)
            .RuleFor(x => x.ContactFullName, x=>x.Name.FullName())
            .RuleFor(x => x.FriendlyName, x=>x.Name.FullName())
            ;

        EventExtensionTookLongerThan2MinToBeAnswered obj = f.Generate();

        obj.Number = Random.Shared.Next(60, 1000).ToString();
        obj.NumberOfSecondsItRang = Random.Shared.Next(120, 1000);

        // set dates
        obj.DateStart = DateTime.UtcNow.AddHours(-1);

        return obj;
    }
}
