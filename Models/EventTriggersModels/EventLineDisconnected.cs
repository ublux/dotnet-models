﻿using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     <see cref="EventTrigger.EventLineDisconnected"/>
/// </summary>
public partial class EventLineDisconnected
{
    /// <summary>
    ///     Line friendly name
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? FriendlyName { get; set; }

    /// <summary>
    ///     Id of phone
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? IdPhone { get; set; }

    /// <summary>
    ///     Name of phone
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? PhoneName { get; set; }

    /// <summary>
    ///     To what extension this line belongs
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? Extension { get; set; }

    /// <summary>
    ///     Its last connection status state
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public LineConnectionStatus? ConnectionStatus { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public override EventLineDisconnected BuildRandomFakeObject()
    {
        var randInstanceId = new RunningApplicationInstance() { Id = "1", CloudServiceType = CloudServiceType.WS };
        var idPhone = Phone.BuildId(randInstanceId);

        Phone phone = new Faker<Phone>()
            .RuleFor(x => x.Id, idPhone.Id)
            .RuleFor(x => x.FriendlyName, x => x.Name.FullName())
            .Generate();

        var idLine = Line.BuildId(randInstanceId, phone.IdAccount, phone.Id);

        var f = new Faker<EventLineDisconnected>()
            .RuleFor(x => x.Id, idLine.Id)
            .RuleFor(x => x.FriendlyName, phone.FriendlyName)
            .RuleFor(x => x.IdPhone, phone.Id)
            .RuleFor(x => PhoneName, phone.FriendlyName + " Mexico")
            .RuleFor(x => Extension, Random.Shared.Next(100, 1000).ToString())
            ;

        EventLineDisconnected obj = f.Generate();

        var randUserAgents = new string[] { "Yealink W60B 77.85.0.20", "Yealink SIP-CP960 73.83.0.30", "Yealink SIP-T58 58.85.0.5", "Yealink SIP-T43U 108.84.0.50" };

        obj.ConnectionStatus = new LineConnectionStatus()
        {
            DateConnected = DateTime.UtcNow.AddHours(-1),
            DateDisconnected = DateTime.UtcNow,
            DisconnectedReason = "registration failure",
            IpLAN = "192.168.1." + Random.Shared.Next(10, 255),
            IpWAN = $"{Random.Shared.Next(10, 255)}.{Random.Shared.Next(10, 255)}.{Random.Shared.Next(10, 255)}.{Random.Shared.Next(10, 255)}",
            IsConnected = false,
            PortLAN = 5061,
            PortWAN = 5061,
            UserAgent = randUserAgents[Random.Shared.Next(0, randUserAgents.Length)]             
        };

        return obj;
    }
}
