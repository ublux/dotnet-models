namespace Ublux.Communications.Models;

/// <summary>
///     Peer to call on power dialer group
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(PowerDialerType))]
[JsonSubtypes.KnownSubType(typeof(PowerDialerSimple), nameof(PowerDialerType.Simple))]
[JsonSubtypes.KnownSubType(typeof(PowerDialerAdvance), nameof(PowerDialerType.Advanced))]
[BsonKnownTypes(
    typeof(PowerDialerAdvance),
    typeof(PowerDialerSimple)
)]
public abstract class PowerDialer
{
    ///// <summary>
    /////     Id of power dialer
    ///// </summary>
    //public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     Type of power dialer
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public abstract PowerDialerType PowerDialerType { get;}

    /// <summary>
    ///     Phone number to call
    /// </summary>
    [IsRequired]
    public string PhoneNumber { get; set; } = string.Empty;

    /// <summary>
    ///     Country ISO code of phone number to call
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     Id of contact
    /// </summary>
    [AllowUpdate(false)]
    public string? IdContact { get; set; }

    /// <summary>
    ///     Status of this item
    /// </summary>
    [IsRequired]
    public PowerDialerStatus PowerDialerStatus { get; set; }

    /// <summary>
    ///     Error message
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     If powerdialer fails it attempts to call again. If it reaches 3 attempts and fails it will stop
    /// </summary>
    public int NumberOfAttempts { get => _numberOfAttempts; set => _numberOfAttempts = value; }
    private int _numberOfAttempts;
    /// <summary/>
    public int IncrementNumberOfAttempts()
    {
        return Interlocked.Increment(ref _numberOfAttempts);
    }
    /// <summary/>
    public int DecrementNumberOfAttempts()
    {
        return Interlocked.Decrement(ref _numberOfAttempts);
    }

    /// <summary>
    ///     Name of the contact in order to know who are we calling
    /// </summary>
    public string? ContactName { get; set; }
}


