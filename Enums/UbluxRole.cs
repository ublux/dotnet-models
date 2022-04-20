namespace Ublux.Communications.Domain.Enums;

// Old code so it could not be AND or OR
// Now we order them based on priority
// 1000 0000 0000 0000 0000 0000 0000 0001 = 2,147,483,649
// 0100 0000 0000 0000 0000 0000 0000 0010 = 1,073,741,826
// 0010 0000 0000 0000 0000 0000 0000 0100 = 536,870,916
// 0001 0000 0000 0000 0000 0000 0000 1000 = 268,435,464
// 0000 1000 0000 0000 0000 0000 0001 0000 = 134,217,744
// 0000 0100 0000 0000 0000 0000 0010 0000 = 67,108,896
// 0000 0010 0000 0000 0000 0000 0100 0000 = 33,554,496
// 0000 0001 0000 0000 0000 0000 1000 0000 = 16,777,344
// 0000 0000 1000 0000 0000 0001 0000 0000 = 8,388,864
// 0000 0000 0100 0000 0000 0010 0000 0000 = 4,194,816 
// 0000 0000 0010 0000 0000 0100 0000 0000 = 2,098,176
// 0000 0000 0001 0000 0000 1000 0000 0000 = 1,050,624
// 0000 0000 0000 1000 0001 0000 0000 0000 = 528,384
// 0000 0000 0000 0100 0010 0000 0000 0000 = 270,336
// 0000 0000 0000 0010 0100 0000 0000 0000 = 147,456
// 0000 0000 0000 0001 1000 0000 0000 0000 = 98,304

/// <summary>
///     A ublux user has this roles. They are sorted in order of priority
/// </summary>
public enum UbluxRole
{
    #region Low priority

    /// <summary> Has access to the phones endpoint with all permissions </summary>
    phones = 10,
    /// <summary> Has access to the phones endpoint with only read permissions </summary>
    phones_readonly,
    /// <summary> Has access to the phones endpoint with only read/update permissions </summary>
    phones_update,
    /// <summary> Has access to the phones endpoint with only read/delete permissions </summary>
    phones_delete,
    /// <summary> Has access to the phones endpoint with only read/create permissions </summary>
    phones_create,

    /// <summary> Has access to the extensions endpoint with all permissions </summary>
    extensions = 20,
    /// <summary> Has access to the extensions endpoint with only read permissions </summary>
    extensions_readonly,
    /// <summary> Has access to the extensions endpoint with only read/update permissions </summary>
    extensions_update,
    /// <summary> Has access to the extensions endpoint with only read/delete permissions </summary>
    extensions_delete,
    /// <summary> Has access to the extensions endpoint with only read/create permissions </summary>
    extensions_create,

    #endregion

    #region Medium Priority

    /// <summary>
    ///     Can execute all endpoints the default user can execute
    /// </summary>
    user = 1000,
    /// <summary> user with only read permissions </summary>
    user_readonly,
    /// <summary> user with only read/update permissions </summary>
    user_update,
    /// <summary> user with only read/delete permissions </summary>
    user_delete,
    /// <summary> user with only read/create permissions </summary>
    user_create,

    /// <summary>
    ///     Can execute admin services. For example it can reboot a PBX. Can also execute user role
    /// </summary>
    admin = 1010,
    /// <summary> admin with only read permissions </summary>
    admin_readonly,
    /// <summary> admin with only read/update permissions </summary>
    admin_update,
    /// <summary> admin with only read/delete permissions </summary>
    admin_delete,
    /// <summary> admin with only read/create permissions </summary>
    admin_create,

    #endregion

    #region Protected High Priority

    /// <summary>
    ///     Web hosting. This is where ublux static website is hosted.
    /// </summary>
    wh = 1000000,

    /// <summary>
    ///     US-1, US-2, etc...
    /// </summary>
    pbx = 2000000,

    /// <summary>
    ///     WebApp. This is where chat and web-phone runs
    /// </summary>
    wa = 3000000,

    /// <summary>
    ///     We have this because now we can have multiple Web Services
    /// </summary>
    ws = 4000000,

    ///// <summary>
    /////     This is the master service that determines a user what WS will use to consume the API
    ///// </summary>
    //MS,   

    #endregion

    #region ROOT

    /// <summary>
    ///     Avoid using this role. has access to everything
    /// </summary>
    root = 1000000000,

    #endregion
}
