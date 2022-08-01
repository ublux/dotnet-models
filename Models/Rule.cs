namespace Ublux.Communications.Models;

/// <summary>
///     Base method for rules
/// </summary>
public class Rule
{
    /// <summary> All days of week </summary>
    public static List<DayOfWeek> DaysOfWeek_All = new() { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
    /// <summary> Days of week from monday to friday </summary>
    public static List<DayOfWeek> DaysOfWeek_MonToFriday = new() { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
}
