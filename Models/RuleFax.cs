namespace Ublux.Communications.Models;

/// <summary>
///     Rule to execute when receiving fax
/// </summary>
public class RuleFax : Rule
{
    /// <summary>
    ///     Email address where to send fax
    /// </summary>
    [IsRequired]
    [AllowUpdate(true)]
    public required string ForwardToEmailAddress { get; set; }
}
