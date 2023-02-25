namespace Ublux.Communications.Models;

/// <summary>
///     Call is blind transferred to an extension
/// </summary>
public class ChildCallBlindTransferToExtension : ChildCallBlindTransfer
{
    /// <summary>
    ///     Extension where it was blind transferred to
    /// </summary>
    [References(typeof(Extension))]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     BlindTransferToExtension
    /// </summary>
    [IsUbluxRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.BlindTransferToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
