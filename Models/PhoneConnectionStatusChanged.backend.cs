#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Used to sync line connection status changes with API
/// </summary>
public class PhoneConnectionStatusChanged
{
    /// <summary>
    ///     Id of line that was modified
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]     
    public required string IdPhone { get; set; } = String.Empty;

    ///// <summary>
    /////     Id of phone
    ///// </summary>
    //[AllowUpdate(false)]
    //public required string IdPhone { get; set; }

    /// <summary>
    ///     Id of Account
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string IdAccount { get; set; }

    /// <summary>
    ///     Clone this to avoid sync problems.
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required PhoneConnectionStatus NewPhoneConnectionStatus { get; set; }
}

#endif