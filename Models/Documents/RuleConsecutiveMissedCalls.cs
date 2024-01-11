namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Send an email if consecutive calls are missed
/// </summary>
public class RuleConsecutiveMissedCalls
{
    /// <summary>
    ///     If this number of consecutive calls are missed an email will be sent.
    /// </summary>
    [AllowUpdate(true)]
    public int NumberConsecutiveCalls { get; set; }

    /// <summary>
    ///     At least one email is required
    /// </summary>
    [References(typeof(Email))]
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public List<string> IdsEmails { get; set; } = [];
}