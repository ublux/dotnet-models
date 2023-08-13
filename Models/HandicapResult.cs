namespace Ublux.Communications.Models;

/// <summary>
///     Handicap result
/// </summary>
public class HandicapResult
{
    /// <summary>
    ///     Extension containing handicap
    /// </summary>
    [References(typeof(Extension))]
    public required string IdExtension { get; set; }

    /// <summary>
    ///     Key = idPhone
    ///     Value = number of answered calls
    /// </summary>
    public Dictionary<string, int> Counts { get; set; } = new();

    /// <summary>
    ///     Date when handicap started
    /// </summary>
    public DateTime DateStarted { get; set; }
}
