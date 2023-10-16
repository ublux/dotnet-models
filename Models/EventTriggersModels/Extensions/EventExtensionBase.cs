using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     When an extension is not answered
/// </summary>
public abstract class EventExtensionBase : EventTriggerModel
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
    public required DateTime DateStart { get; set; }

    /// <summary>
    ///     Id of contact that made phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactId { get; set; }

    /// <summary>
    ///     Name of contact that made phone call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactFullName { get; set; }

    /// <summary>
    ///     How long extension ring?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required double NumberOfSecondsItRing { get; set; }

    /// <summary>
    ///     Id of lines that ring
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required List<string> PhonesThatRingIds { get; set; } = new();

    /// <summary>
    ///     Id of lines that ring dit not ring
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required List<string> PhonesThatDidNotRingIds { get; set; } = new();

    /// <summary>
    ///     Name of lines that ring
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required List<string> PhonesThatRingFriendlyNames { get; set; } = new();

    /// <summary>
    ///     Name of lines that ring dit not ring
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required List<string> PhonesThatDidNotRingFriendlyNames { get; set; } = new();

    /// <summary>
    ///     Return a random object
    /// </summary>
    protected static T GetRandomBase<T>(RunningApplicationInstance instance) where T : EventExtensionBase
    {
        var randomId = ExtensionDial.BuildId(instance).Id;
        var randomIdContact = Contact.BuildId(instance).Id;

        var f = new Faker<T>()
            .RuleFor(x => x.Id, randomId)
            .RuleFor(x => x.From, x => x.Phone.PhoneNumberFormat())
            .RuleFor(x => x.To, x => x.Phone.PhoneNumberFormat())
            .RuleFor(x => x.ContactId, randomIdContact)
            .RuleFor(x => x.ContactFullName, x => x.Name.FullName())
            .RuleFor(x => x.FriendlyName, x => x.Name.FullName())
            .RuleFor(x => x.NumberOfSecondsItRing, Random.Shared.Next(0, 60))
            .RuleFor(x => x.Number, Random.Shared.Next(10, 1000).ToString())
            .RuleFor(x => x.DateStart, DateTime.UtcNow.AddHours(-1))
            ;

        var obj = f.Generate();

        // random index of name
        var randStart = Random.Shared.Next(0, 95);

        // set lines that ring
        var numOfPhonesThatRing = 3;
        for (int i = 0; i < numOfPhonesThatRing; i++)
        {
            GenerateRandomIdAccountPhoneAndPhone(instance, out _, out _);
            //obj.PhonesThatRingIds.Add(idPhone);
            obj.PhonesThatRingFriendlyNames.Add(Constants.RandomNames[randStart + i]);
        }

        // set lines that did not ring
        for (int i = 0; i < 2; i++)
        {
            GenerateRandomIdAccountPhoneAndPhone(instance, out _, out _);
            //obj.PhonesThatDidNotRingIds.Add(idPhone);
            obj.PhonesThatDidNotRingFriendlyNames.Add(Constants.RandomNames[randStart + i + numOfPhonesThatRing]);
        }

        return obj;
    }
}
