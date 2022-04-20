namespace Ublux.Communications.Domain.Enums;

/// <summary>
///     CRUD Permissions
/// </summary>
// [Flags]
public enum Permissions
{
    /// <summary>
    ///     Letter C of CRUD
    /// </summary>
    Create = 1,

    /// <summary>
    ///     Letter R of CRUD
    /// </summary>
    Read = 2,

    /// <summary>
    ///     Letter U of CRUD
    /// </summary>
    Update = 4,

    /// <summary>
    ///     Letter D of CRUD
    /// </summary>
    Delete = 8,
}
