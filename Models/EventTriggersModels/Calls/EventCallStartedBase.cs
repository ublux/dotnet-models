using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Base class for calls
/// </summary>
public abstract class EventCallStartedBase : EventTriggerModel
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
    ///     If call is incoming then the contact that made phone call.
    ///     If call is outgoing then the contact that we are calling.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactId { get; set; }

    /// <summary>
    ///     If call is incoming then the name of contact that made phone call.
    ///     If call is outgoing then the name of contact that we are calling.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactFullName { get; set; }

    /// <summary>
    ///     Errors of call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required CallErrors CallErrors { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    protected T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventCallStartedBase
    {
        var randChannel = Random.Shared.Next(100000, 999999);
        string randomIdCall = CallOutgoingToPSTN.BuildId(instance, randChannel + ".0").Id;
        var randomIdContact = Contact.BuildId(instance).Id;

        var f = new Faker<T>()
            .RuleFor(x => x.Id, randomIdCall)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.ContactId, randomIdContact)
            .RuleFor(x => x.ContactFullName, x => x.Name.FullName())
            .RuleFor(x => x.DateStart, DateTime.UtcNow.AddHours(-1))
        ;

        var obj = f.Generate();
        return obj;
    }
}
