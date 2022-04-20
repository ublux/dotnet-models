namespace Ublux.Communications.Domain.Models.SubDocuments;

/// <summary>
///     It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary>
public class Line : UbluxSubDocument // this is a subdocument
{
    ///// <inheritdoc />
    //public override string SubDocumentPrefix() => "SubLi";

    ///// <inheritdoc />
    //public override void SetId() => _id =
    //    $"{UCore.InstanceId}:{SubDocumentPrefix()}:{DateTime.UtcNow.ToUnixEpoch()}:{Interlocked.Increment(ref DomainGlobals.IdGenerationCounter)}";

    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string FriendlyName { get; set; } = String.Empty;

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
    [IsRequired]
    public string CallerIdNumber { get; set; } = string.Empty;

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

}