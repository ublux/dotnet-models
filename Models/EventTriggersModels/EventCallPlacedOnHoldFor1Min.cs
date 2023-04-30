using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventCallPlacedOnHoldFor1Min"/>
/// </summary>
public partial class EventCallPlacedOnHoldFor1Min
{
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
    ///     Date when call was answered. If null it means it has not been answered
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public double? SecondsItTookToAnswer { get; set; }    

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

    // its one min
    ///// <summary>
    /////     Number of seconds call has been on hold
    ///// </summary>
    //[AllowUpdate(false)]
    //public int NumberOfSecondsCallOnHold { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventCallPlacedOnHoldFor1Min BuildRandomFakeObject(RunningApplicationInstance instance)
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var randChannel = Random.Shared.Next(100000, 999999);
        var randomId = CallIncomingToExtension.BuildId(instance, $"{randChannel}.0").Id;
        var randomIdContact = Contact.BuildId(instance).Id;

        var f = new Faker<EventCallPlacedOnHoldFor1Min>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.IdContact, randomIdContact)
            .RuleFor(x => x.ContactFullName, x=>x.Name.FullName())
            ;

        EventCallPlacedOnHoldFor1Min obj = f.Generate();
        
        // set dates
        obj.DateStart = DateTime.UtcNow.AddHours(-1);
        obj.SecondsItTookToAnswer = 10;
        // obj.NumberOfSecondsCallOnHold = Random.Shared.Next(60, 3600);
        //obj.DateEnded = obj.DateAnswer.Value.AddSeconds(Random.Shared.Next(10, 3600));

        return obj;
    }
}
