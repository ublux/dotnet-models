using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

public partial class EventCallPlacedOnHoldFor4Min
{
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
    ///     Date when call was answered. If null it means it has not been answered
    /// </summary>
    [AllowUpdate(false)]
    public int? SecondsItTookToAnswer { get; set; }    

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

    // its one min
    ///// <summary>
    /////     Number of seconds call has been on hold
    ///// </summary>
    //[AllowUpdate(false)]
    //public int NumberOfSecondsCallOnHold { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventCallPlacedOnHoldFor4Min BuildRandomFakeObject()
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var randChannel = Random.Shared.Next(100000, 999999);
        var randomId = CallIncomingToExtension.BuildId(randInstanceId, $"{randChannel}.0").Id;
        var randomIdContact = Contact.BuildId(randInstanceId).Id;

        var f = new Faker<EventCallPlacedOnHoldFor4Min>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.IdContact, randomIdContact)
            .RuleFor(x => x.ContactFullName, x=>x.Name.FullName())
            ;

        EventCallPlacedOnHoldFor4Min obj = f.Generate();
        
        // set dates
        obj.DateStart = DateTime.UtcNow.AddHours(-1);
        obj.SecondsItTookToAnswer = 10;
        // obj.NumberOfSecondsCallOnHold = Random.Shared.Next(60, 3600);
        //obj.DateEnded = obj.DateAnswer.Value.AddSeconds(Random.Shared.Next(10, 3600));

        return obj;
    }
}
