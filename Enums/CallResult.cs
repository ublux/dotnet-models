namespace Ublux.Communications.Enums;

/// <summary>
///     How a call is categorized as agent when completed
/// </summary>
public enum CallResult
{
    /// <summary>
    ///     No result
    /// </summary>
    None,

    /// <summary>
    ///     Call is a sale
    /// </summary>
    Sale,

    /// <summary>
    ///     Interested
    /// </summary>
    Interested,

    /// <summary>
    ///     Reschedule
    /// </summary>
    Reschedule,

    /// <summary>
    ///     Not interested
    /// </summary>
    NotInterested,

    /// <summary>
    ///     Do not call
    /// </summary>
    DoNotCall
}
