namespace Ublux.Communications.Models.FlowNodes;

/// <summary> For example from Monday to Friday </summary>
public partial class NodeWeekDays
{
    /// <summary>
    ///     Inclusive start day of week
    /// </summary>
    public required DayOfWeek Start { get; set; }

    /// <summary>
    ///     Incluse end day of week
    /// </summary>
    public required DayOfWeek End { get; set; }
}
