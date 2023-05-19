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
    ///     For example when an extension queue is not answered and it forwards the cal to another extension.
    /// </summary>
    ForwardToExtension,

    /// <summary>
    ///     For example when extension dial is not answered and we need to forward the call to its movil.
    ///     Same thing when executing a CallFlowLogic and we execute the NodeCall
    /// </summary>
    ForwardToPSTN,

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
