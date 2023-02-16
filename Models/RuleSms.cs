namespace Ublux.Communications.Models;

/// <summary>
///     Rule to execute when receiving SMS
/// </summary>
public class RuleSms
{
    /// <summary>
    ///     Email address where to send SMS
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(true)]
    [References(typeof(Email))]
    public required string IdEmail { get; set; } = "";
}
