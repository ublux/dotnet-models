namespace Ublux.Communications.Models.FlowNodes;

/// <summary></summary>
public partial class NodePlay : INodePlay
{
    /// <summary>
    ///     Audio to play
    /// </summary>
    public required string IdAudio { get; set; }

    #region INodePlay

    /// <summary>
    ///     Save and collect digits user enters
    /// </summary>
    public bool CollectDigits { get; set; }

    /// <summary>
    ///     Maximum number of digits to collect
    /// </summary>
    public int MaxNumberOfDigits { get; set; }

    /// <summary>
    ///     Time to wait to collect digits after text is said
    /// </summary>
    public int Timeout { get; set; }

    #endregion
}
