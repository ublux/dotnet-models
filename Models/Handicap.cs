namespace Ublux.Communications.Models;

/// <summary>
///     Handicap feature where if a phone takes a lot of calls it will not ring next time.
///     Every time a phone answers it will increase its count. If extension is not answered then it will decrease count to all
/// </summary>
public class Handicap
{
    ///// <summary>
    /////     IdExtension
    ///// </summary>
    //[AllowUpdate(true)]
    //[UbluxValidationNotRequired]
    //[References(typeof(Extension))]
    //public required string IdExtension { get; set; }

    /// <summary>
    ///     Stop ringing if it reaches this max count
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationNotRequired]
    public int StopRingingIfCountReaches { get; set; }

    /// <summary>
    ///     If value is 0 it will never be reseted
    /// </summary>
    public int ResetInMinutes { get; set; }
}
