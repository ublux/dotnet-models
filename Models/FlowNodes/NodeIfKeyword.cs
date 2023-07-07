namespace Ublux.Communications.Models.FlowNodes;

/// <summary>
///     Can either play an audio or convert text to speech meanwhile waiting for keywords
/// </summary>
public partial class NodeIfKeyword
{
    /// <summary>
    ///     Language
    /// </summary>
    public Language Language { get; set; } = Language.EN_US;

    /// <summary>
    ///     Time to wait after audio is played to capure keyword
    /// </summary>
    public int Timeout { get; set; } = 5;

    /// <summary>
    ///     Audio to play
    /// </summary>
    public string? IdAudio { get; set; }

    /// <summary>
    ///     Type of voice. Example: US English - Joanna
    /// </summary>
    public string? Voice { get; set; }

    /// <summary>
    ///     Text to say
    /// </summary>
    [UbluxValidationStringRange(1, 2000)]
    public string? Text { get; set; }
}

