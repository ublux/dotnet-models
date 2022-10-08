namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary>
public partial class Line : UbluxSubDocument
{
    /// <summary>
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Line status
    /// </summary>
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public LineConnectionStatus? LineConnectionStatus { get; set; }

    /// <summary>
    ///     Caller id number that will be used to place outbound calls
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string CallerIdNumber { get; set; }

    /// <summary>
    ///     Record outbound calls to PSTN?
    /// </summary>
    [AllowUpdate(true)]
    public bool RecordExternalCalls { get; set; }

    /// <summary>
    ///     Record calls to other extensions?
    /// </summary>
    [AllowUpdate(true)]
    public bool RecordInternalCalls { get; set; }

    /// <summary>
    ///     Langage to use when playing messages
    /// </summary>
    [AllowUpdate(true)]
    public Language Language { get; set; }
}