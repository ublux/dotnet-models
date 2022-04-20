namespace Ublux.Communications.Models;

/// <summary>
///     Rule to execute when receiving SMS
/// </summary>
public class RuleSms
{
    /// <summary>
    ///     Email address where to send SMS
    /// </summary>
    [IsRequired]
    [AllowUpdate(true)]
    public string ForwardToEmailAddress { get; set; } = string.Empty;
}
