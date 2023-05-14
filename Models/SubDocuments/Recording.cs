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
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(2000)]
    public string? ErrorMessage { get; set; }

    /// <summary>
    ///     Recording in client in Mp3 format
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public StoredFile? RecordingClientMp3 { get; set; }

    /// <summary>
    ///     Recording in agent in Mp3 format
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public StoredFile? RecordingAgentMp3 { get; set; }

    /// <summary>
    ///     Recording of agent and client mixed.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public StoredFile? RecordingMp3 { get; set; }

    /// <summary>
    ///     Duration of recording
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double RecordingDurationInSeconds { get; set; }
}
