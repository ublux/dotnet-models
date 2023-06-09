#if UBLUX_BACKEND

namespace Ublux.Communications.Enums;

/// <summary>
///     Provider that hosts this cloud service
/// </summary>
public enum CloudServiceProviderType
{
    /// <summary>
    ///     This is the case with Canal-Park where we have our own server
    /// </summary>
    None,

    /// <summary>
    ///     Amazon
    /// </summary>
    AWS,

    /// <summary>
    ///     Microsoft
    /// </summary>
    Azure,

    /// <summary>
    ///     Hosted on Canal-Park or office
    /// </summary>
    Ublux,
}

#endif