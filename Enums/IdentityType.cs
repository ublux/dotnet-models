namespace Ublux.Communications.Enums;

/// <summary>
///     Use flags in case we may need to specify multiple UserTypes
/// </summary>
// [Flags]
public enum IdentityType
{
    /// <summary>
    ///     Unknown user type
    /// </summary>
    None = 0,

    ///// <summary>
    /////     This is the default user that exists per every account in ublux. Its id should be its email address
    ///// </summary>
    //Default = 1,

    /// <summary>
    ///     This are users that can consume ublux web api. A default user should be created per account and should not be deleted.
    /// </summary>
    User = 1,

    // Identity points to phone instead
    ///// <summary>
    /////     This user is the one that uses webphone for example
    ///// </summary>
    //Phone = 2,

    /// <summary>
    ///     US-1, US-2, etc...
    /// </summary>
    PBX = 2,

    /// <summary>
    ///     Web hosting. This is where ublux static website is hosted.
    /// </summary>
    WH = 4,

    /// <summary>
    ///     WebApp. This is where chat and web-phone runs
    /// </summary>
    WA = 8,

    /// <summary>
    ///     We have this because now we can have multiple Web Services
    /// </summary>
    WS = 16,

    ///// <summary>
    /////     This is the master service that determines a user what WS will use to consume the API
    ///// </summary>
    //MS = 32,
}
