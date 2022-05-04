#if UBLUX_BACKEND
namespace Ublux.Communications.Enums;

/// <summary>
///     Types of trunk originations
/// </summary>
public enum TrunkOriginationType
{
    /// <summary>
    ///     Twilio uses this type of trunk origination where it will forward traffic to our PBX
    /// </summary>
    Forward,

    /// <summary>
    ///     Netbox solutions uses this type of trunk where we must register in order to receive phone calls
    /// </summary>
    Register
}
#endif