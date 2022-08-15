namespace Ublux.Communications.Enums;

/// <summary>
///     Ring strategy of a queue
/// </summary>
public enum QueueRingStrategy
{    
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
    ///     Line answered a call and placed that call on hold
    /// </summary>
    Linear,
}
