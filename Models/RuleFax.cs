namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Rule to execute when receiving fax
/// </summary>
public class RuleFax
{
    /// <summary>
    ///     Email address where to send fax
    /// </summary>
    [Required]
    [AllowUpdate(true)]
    public string ForwardToEmailAddress { get; set; } = String.Empty;
}
