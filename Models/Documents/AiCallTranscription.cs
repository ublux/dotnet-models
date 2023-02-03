namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class AiCallTranscription : UbluxDocument, IReferencesTags
{
    #region References    

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> IdsTags { get; set; } = new();

    /// <summary>
    ///     Call being transcribed
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Call))]
    [IsUbluxRequired]
    public string IdCall { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     If there is a language it means there is a transcription
    /// </summary>
    [AllowUpdate(false)]
    public string? TranscriptionLanguage { get; set; }

    /// <summary>
    ///     Audio of agent converted to text
    /// </summary>
    [AllowUpdate(false)]
    public List<AiTranscription> TranscriptionAgent { get; set; } = new();

    /// <summary>
    ///     Audio of client converted to text
    /// </summary>
    [AllowUpdate(false)]
    public List<AiTranscription> TranscriptionClient { get; set; } = new();

    /// <summary>
    ///     Summary of agent transcription
    /// </summary>
    [AllowUpdate(false)]
    public string? TranscriptionAgentSummary { get; set; }

    /// <summary>
    ///     Summary of client transcription
    /// </summary>
    [AllowUpdate(false)]
    public string? TranscriptionClientSummary { get; set; }

    /// <summary>
    ///     Entity detection summary for client
    /// </summary>
    [AllowUpdate(false)]
    public List<AiEntityDetection> AiSentimentAnalysisClientSummary { get; set; } = new();

    /// <summary>
    ///     Entity detection summary for agent
    /// </summary>
    [AllowUpdate(false)]
    public List<AiEntityDetection> AiSentimentAnalysisAgentSummary { get; set; } = new();

    /// <summary>
    ///     AI Topic Modeling Summary
    /// </summary>
    [AllowUpdate(false)]
    public List<AiTopicModelingSummary> AiTopicModelingSummary { get; set; } = new();
}