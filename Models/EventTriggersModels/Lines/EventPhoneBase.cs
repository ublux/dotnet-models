using Bogus;

namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     When a line is connected or disconnected
/// </summary>
public abstract class EventPhoneBase : EventTriggerModel
{
    /// <summary>
    ///     Phone friendly name
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? FriendlyName { get; set; }

    ///// <summary>
    /////     Id of phone
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public string? PhoneId { get; set; }

    /// <summary>
    ///     Name of phone
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? PhoneFriendly { get; set; }

    /// <summary>
    ///     To what extension this line belongs
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ExtensionFriendlyName { get; set; }

    /// <summary>
    ///     To what id extension this line belongs too
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ExtensionId { get; set; }

    /// <summary>
    ///     To what extension number this line belongs too
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ExtensionNumber { get; set; }

    /// <summary>
    ///     Phone last connection status state
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public PhoneConnectionStatus? ConnectionStatus { get; set; }

    /// <summary>
    ///     Return a random object
    /// </summary>
    public T RandomBase<T>(RunningApplicationInstance instance) where T : EventPhoneBase
    {
        var accountIdBuild = Account.BuildId(Random.Shared.Next(100, 10000).ToString());

        GenerateRandomIdAccountPhoneAndPhone(instance, out _, out _);

        var f = new Faker<T>()
            .RuleFor(x => x.FriendlyName, x => x.Name.FullName())
            ;

        var obj = f.Generate();
        obj.PhoneFriendly = obj.FriendlyName;
        obj.ExtensionFriendlyName = "Extension " + obj.FriendlyName;
        obj.ExtensionId = ExtensionDial.BuildId(instance).Id;
        obj.ExtensionNumber = Random.Shared.Next(10, 1000).ToString();

        var randUserAgents = new string[] { "Yealink W60B 77.85.0.20", "Yealink SIP-CP960 73.83.0.30", "Yealink SIP-T58 58.85.0.5", "Yealink SIP-T43U 108.84.0.50" };

        obj.ConnectionStatus = new PhoneConnectionStatus()
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
