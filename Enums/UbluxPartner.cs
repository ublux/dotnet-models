﻿#if UBLUX_BACKEND
namespace Ublux.Communications.Enums;

/// <summary>
///     This will be the Ublux partner. For example Victor has nothing to do with Canal Park.
/// </summary>
public enum UbluxPartner
{
    /// <summary>
    ///     No partner
    /// </summary>
    None,

    /// <summary>
    ///     Clients with Eduardo Namnum.
    /// </summary>
    CanalPark,

    /// <summary>
    ///     Clients with Victor Lopez. For now mostly on Spain.
    /// </summary>
    Victor,

    ///// <summary>
    /////     Clients with Daniel Mosquera
    ///// </summary>
    //Daniel,

    //DanielAndFernando,
    //Fernando
}
#endif