namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Date when call was placed on hold
/// </summary>
public class TimeWhenCallPlacedOnHold
{
    /// <summary>
    ///     Seconds elapsed since the call started when call was placed on hold
    /// </summary>
    [Required]
    [AllowUpdate(true)]
    public int SecondsElapsedWhenPlacedOnHold { get; set; }

    /// <summary>
    ///     Seconds elapsed since the call started when call was removed from hold
    /// </summary>
    public int? SecondsElapsedWhenRemovedFromHold { get; set; }
}
