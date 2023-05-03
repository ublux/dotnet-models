using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     Base class when a call is placed on hold for too long.
/// </summary>
public abstract class EventCallPlacedOnHoldBase : EventTriggerModel
{
    /// <summary>
    ///     Is the call incoming? If false call is outgiong
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required bool IsIncoming { get; set; }

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
    public string? ContactId { get; set; }

    /// <summary>
    ///     Name of contact
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactFullName { get; set; }

    /// <summary>
    ///     If it is an incoming call then the id of line that answered the call.
    ///     If it is an outgiong call then the id of the line that initiated the call.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string LineId { get; set; }

    /// <summary>
    ///     If it is an incoming call then the friendly name of the line that answered the call.
    ///     If it is an outgiong call then the friendly name of the line that initiated the call.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string LineFriendlyName { get; set; }

    /// <summary>
    ///     Helper method to generate random
    /// </summary>
    protected T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventCallPlacedOnHoldBase
    {
        var randChannel = Random.Shared.Next(100000, 999999);
        var randomIdCall = CallIncomingToExtension.BuildId(instance, $"{randChannel}.0").Id;
        var randomIdContact = Contact.BuildId(instance).Id;

        var f = new Faker<T>()
            .RuleFor(x => x.Id, randomIdCall)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat(0))
            .RuleFor(x => x.ContactId, randomIdContact)
            .RuleFor(x => x.ContactFullName, x => x.Name.FullName())
            .RuleFor(x => x.DateStart, DateTime.UtcNow.AddHours(-1))
            .RuleFor(x => x.SecondsItTookToAnswer, Random.Shared.Next(10, 15))
            ;

        var obj = f.Generate();

        GenerateRandomIdAccountPhoneAndLine(instance, out _, out _, out var idLine);
        obj.LineId = idLine;
        obj.LineFriendlyName = Constants.RandomNames[Random.Shared.Next(0, Constants.RandomNames.Length)];

        return obj;
    }
}
