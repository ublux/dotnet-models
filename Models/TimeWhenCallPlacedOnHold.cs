namespace Ublux.Communications.Models;

/// <summary>
///     Date when call was placed on hold
/// </summary>
public class TimeWhenCallPlacedOnHold
{
    /// <summary>
    ///     Seconds elapsed since the call started when call was placed on hold
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required double SecondsElapsedWhenPlacedOnHold { get; set; }

    /// <summary>
    ///     Seconds elapsed since the call started when call was removed from hold
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public double? SecondsElapsedWhenRemovedFromHold { get; set; }
}
