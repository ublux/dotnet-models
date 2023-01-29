#if UBLUX_BACKEND

namespace Ublux.Communications.Enums;

/// <summary>
///     Type of message WS sends a pbx
/// </summary>
public enum BinaryTcpMessageType : byte
{
    /// <summary>
    ///     Empty message sends value 0
    /// </summary>
    Ping = 0,

    /// <summary>
    ///     Prints a message to the console. So it only takes a string. The same string is sent as a resposne
    /// </summary>
    PrintMessage
}

#endif