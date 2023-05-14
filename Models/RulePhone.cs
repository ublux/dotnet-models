namespace Ublux.Communications.Models;

/// <summary>
///     Rule that determines what action to execute when a phone call is received.
/// </summary>
public class RulePhone : Rule
{
    /// <summary>
    ///     Id of Call Flow (IVR) to execute
    /// </summary>
    [References(typeof(CallFlowLogic))]
    [AllowUpdate(true)]
    public string? IdCallFlowLogic { get; set; }

    /// <summary>
    ///     Id of extension to call
    /// </summary>
    [References(typeof(Extension))]
    [AllowUpdate(true)]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Day of week when to execute
    /// </summary>
    [UbluxValidationIsRequired]
    [AllowUpdate(true)]
    [BsonRepresentation(BsonType.String)]
    public required List<DayOfWeek> DaysOfWeek { get; set; }
}
