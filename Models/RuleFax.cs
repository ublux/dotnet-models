// ReSharper disable CheckNamespace
namespace Ublux.Communications.Models;

/// <summary>
///     Rule to execute when receiving fax
/// </summary>
public class RuleFax : Rule
{
    /// <summary>
    ///     Email address where to send fax
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    [References(typeof(Email))]
    public required string IdEmail { get; set; }
}
