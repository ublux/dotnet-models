namespace Ublux.Communications.Models;

/// <summary>
///     Date when call was placed on hold
/// </summary>
public class TimeWhenCallPlacedOnHold
{
    /// <summary>
    ///     Seconds elapsed since the call started when call was placed on hold
    /// </summary>
    [IsRequired]
    [AllowUpdate(false)]
    public required int SecondsElapsedWhenPlacedOnHold { get; set; }

    /// <summary>
    ///     Seconds elapsed since the call started when call was removed from hold
    /// </summary>
    [AllowUpdate(false)]
    public int? SecondsElapsedWhenRemovedFromHold { get; set; }
}
