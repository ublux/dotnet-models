﻿namespace Ublux.Communications.Enums;

/// <summary>
///     Type of extension
/// </summary>
public enum ExtensionType
{
    /// <summary>
    ///     No type
    /// </summary>
    None,

    /// <summary>
    ///     Executes an IVR
    /// </summary>
    CallFlowLogic,
    /// <summary>
    ///     Conference
    /// </summary>
    Conference,
    /// <summary>
    ///     Basic Dial
    /// </summary>
    Dial,
    /// <summary>
    ///     Queue
    /// </summary>
    Queue,
    /// <summary>
    ///     Voicemail
    /// </summary>
    Voicemail,
}
