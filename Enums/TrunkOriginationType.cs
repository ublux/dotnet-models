#if UBLUX_BACKEND
namespace Ublux.Communications.Enums;

/// <summary>
///     Types of trunk originations
/// </summary>
public enum TrunkOriginationType
{
    /// <summary>
    ///     No type
    /// </summary>
    None,

    /// <summary>
    ///     Twilio uses this type of trunk origination where it will forward traffic to our PBX
    /// </summary>
    Forward,

    /// <summary>
    ///     Not implemented case. On the old version of ublux our provider from mexico uses this technique.
    /// </summary>
    Register
}
#endif