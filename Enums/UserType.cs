namespace Ublux.Communications.Enums;

/// <summary>
///     Use flags in case we may need to specify multiple UserTypes
/// </summary>
// [Flags]
public enum UserType
{
    /// <summary>
    ///     Unknown user type
    /// </summary>
    None,

    ///// <summary>
    /////     This is the default user that exists per every account in ublux. Its id should be its email address
    ///// </summary>
    //Default = 1,

    /// <summary>
    ///     This are users that can consume ublux web api. A default user should be created per account and should not be deleted.
    /// </summary>
    Admin,

    /// <summary>
    ///     Support user
    /// </summary>
    Support,

    /// <summary>
    ///     US-1, US-2, etc...
    /// </summary>
    PBX,

    /// <summary>
    ///     WebApp. This is where chat and web-phone runs
    /// </summary>
    WA,

    /// <summary>
    ///     Web hosting. This is where ublux static website is hosted.
    /// </summary>
    WH,

    /// <summary>
    ///     This is used by API to send a request to the other API to monitor its statuses
    /// </summary>
    API,
    
    /// <summary>
    ///     Transcription services that transcribe audio to text
    /// </summary>
    TS
}
