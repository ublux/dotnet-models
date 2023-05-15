namespace Ublux.Communications.Enums;

/// <summary>
///     Type of child call
/// </summary>
public enum ChildCallType
{
    /// <summary>
    ///     Unknown
    /// </summary>
    None,

    /// <summary>
    ///     Automatic forward/transfer
    /// </summary>
    ForwardToExtension,
    /// <summary>
    ///     Attendant transfer to extension
    /// </summary>
    AttendantTransferToExtension,
    /// <summary>
    ///     Attendant transfer to land-line or cell-phone
    /// </summary>
    AttendantTransferToPSTN,
    /// <summary>
    ///     Blind transfer to extension
    /// </summary>
    BlindTransferToExtension,
    /// <summary>
    ///     Blind transfer to land-line or cell-phone
    /// </summary>
    BlindTransferToPSTN
}
