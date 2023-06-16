namespace Ublux.Communications.Enums;

/// <summary>
///     Ring strategy of a queue
/// </summary>
public enum QueueRingStrategy
{
    /// <summary>
    ///     No strategy
    /// </summary>
    None,

    /// <summary>
    ///     All lines will ring
    /// </summary>
    RingAll,

    /// <summary>
    ///     Least resent 
    /// </summary>
    LeastResent,

    /// <summary>
    ///     Member that has the fewest calls will ring
    /// </summary>
    FewestCalls,

    /// <summary>
    ///     Random line will ring
    /// </summary>
    Random,

    /// <summary>
    ///     Round robin algorithm
    /// </summary>
    RoundRobin,

    /// <summary>
    ///     Rings in order
    /// </summary>
    Linear,
}
