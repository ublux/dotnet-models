namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     Recording of a phone call
/// </summary>
public partial class Recording : UbluxSubDocument
{
    ///// <inheritdoc />
    //public override string SubDocumentPrefix() => "SubRe";

    /// <summary>
    ///     Description of error message if there is one
    /// </summary>
    [AllowUpdate(false)]
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     Recording in Mp3 format
    /// </summary>
    [AllowUpdate(false)]
    public StoredFile? RecordingMp3 { get; set; }

    /// <summary>
    ///     Duration of recording
    /// </summary>
    [AllowUpdate(false)]
    public int RecordingDurationInSeconds { get; set; }

}
