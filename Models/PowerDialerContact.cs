﻿namespace Ublux.Communications.Models;

/// <summary>
///     Peer to call on power dialer group
/// </summary>
//[JsonConverter(typeof(JsonSubtypes), nameof(PowerDialerType))]
//[JsonSubtypes.KnownSubType(typeof(PowerDialerSimple), nameof(PowerDialerType.Simple))]
//[JsonSubtypes.KnownSubType(typeof(PowerDialerAdvance), nameof(PowerDialerType.Advanced))]
//[BsonKnownTypes(
//    typeof(PowerDialerAdvance),
//    typeof(PowerDialerSimple)
//)]
public class PowerDialerContact
{
    ///// <summary>
    /////     Id of power dialer
    ///// </summary>
    //public required string Id { get; set; }
   
    /// <summary>
    ///     Phone number to call
    /// </summary>
    [UbluxValidationRequired]
    public required string PhoneNumber { get; set; }

    ///// <summary>
    /////     If a call flow logic needs to be executed before calling contact.
    ///// </summary>
    //[References(typeof(CallFlowLogic))]
    //public string? IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Country ISO code of phone number to call
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [UbluxValidationRequired]
    public required CountryIsoCode CountryIsoCode { get; set; }

    /// <summary>
    ///     Id of contact
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? IdContact { get; set; }

    /// <summary>
    ///     Status of this item
    /// </summary>
    [UbluxValidationRequired]
    public required PowerDialerStatus PowerDialerStatus { get; set; }

    /// <summary>
    ///     Error message
    /// </summary>
    [UbluxValidationStringRange(1000)]
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