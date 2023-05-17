namespace Ublux.Communications.Models.FlowNodes;

/// <summary></summary>
public partial class NodeSay : INodePlay
{
    /// <summary>
    ///     Type of voice. Example: US English - Joanna
    /// </summary>
    public required string Voice { get; set; }

    /// <summary>
    ///     Text to say
    /// </summary>
    [UbluxValidationStringRange(1, 2000)]
    public required string Text { get; set; }

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
