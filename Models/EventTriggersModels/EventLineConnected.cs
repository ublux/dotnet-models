using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventLineConnected"/>
/// </summary>
public partial class EventLineConnected
{
    /// <summary>
    ///     Line friendly name
    /// </summary>
    [AllowUpdate(false)]
    public string? FriendlyName { get; set; }

    /// <summary>
    ///     Id of phone
    /// </summary>
    [AllowUpdate(false)]
    public string? IdPhone { get; set; }

    /// <summary>
    ///     Name of phone
    /// </summary>
    [AllowUpdate(false)]
    public string? PhoneName { get; set; }

    /// <summary>
    ///     To what extension this line belongs
    /// </summary>
    [AllowUpdate(false)]
    public string? Extension { get; set; }

    /// <summary>
    ///     Its last connection status state
    /// </summary>
    [AllowUpdate(false)]
    public LineConnectionStatus? ConnectionStatus { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventLineConnected BuildRandomFakeObject()
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var idPhone = Phone.BuildId(randInstanceId);

        Phone phone = new Faker<Phone>()
            .RuleFor(x => x.Id, idPhone.Id)
            .RuleFor(x => x.FriendlyName, x => x.Name.FullName())
            .Generate();

        var idLine = Line.BuildId(randInstanceId, phone);

        var f = new Faker<EventLineConnected>()
            .RuleFor(x => x.Id, idLine.Id)
            .RuleFor(x => x.FriendlyName, phone.FriendlyName)
            .RuleFor(x => x.IdPhone, phone.Id)
            .RuleFor(x => PhoneName, phone.FriendlyName + " Mexico")
            .RuleFor(x => Extension, Random.Shared.Next(100, 1000).ToString())
            ;

        EventLineConnected obj = f.Generate();

        var randUserAgents = new string[] { "Yealink W60B 77.85.0.20", "Yealink SIP-CP960 73.83.0.30", "Yealink SIP-T58 58.85.0.5", "Yealink SIP-T43U 108.84.0.50" };

        obj.ConnectionStatus = new LineConnectionStatus()
        {
            DateConnected = DateTime.UtcNow,
            DateDisconnected = DateTime.UtcNow.AddHours(-1),
            DisconnectedReason = null,
            IpLAN = "192.168.1." + Random.Shared.Next(10, 255),
            IpWAN = $"{Random.Shared.Next(10, 255)}.{Random.Shared.Next(10, 255)}.{Random.Shared.Next(10, 255)}.{Random.Shared.Next(10, 255)}",
            IsConnected = true,
            PortLAN = 5061,
            PortWAN = 5061,
            UserAgent = randUserAgents[Random.Shared.Next(0, randUserAgents.Length)]             
        };

        return obj;
    }
}
